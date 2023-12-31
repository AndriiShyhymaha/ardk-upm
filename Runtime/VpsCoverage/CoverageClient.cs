﻿// Copyright 2022 Niantic, Inc. All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Niantic.Lightship.AR.Loader;
using Niantic.Lightship.AR.Settings.User;
using UnityEngine;

namespace Niantic.Lightship.AR
{
    public class CoverageClient
    {
        private const string VpsCoverageEndpoint = "https://vps-coverage-api.nianticlabs.com/api/json/v1/";
        private const string CoverageAreasMethodName = "GET_VPS_COVERAGE";
        private const string LocalizationTargetMethodName = "GET_VPS_LOCALIZATION_TARGETS";
        private const string CoverageAreasEndpoint = VpsCoverageEndpoint + CoverageAreasMethodName;
        private const string LocalizationTargetsEndpoint = VpsCoverageEndpoint + LocalizationTargetMethodName;

        private readonly LightshipSettings _lightshipSettings;

        public CoverageClient(LightshipSettings lightshipSettings) => _lightshipSettings = lightshipSettings;

        private async Task<CoverageAreasResult> RequestCoverageAreasAsync(LatLng queryLocation, int queryRadius)
        {
            _CoverageAreasRequest request;

            // Server side we use radius == 0 then use max radius, radius < 0 then set radius to 0.
            // Client side we want a to use radius == 0 then radius = 0, radius < 0 then use max radius.
            if (queryRadius == 0)
            {
                queryRadius = -1;
            }
            else if (queryRadius < 0)
            {
                queryRadius = 0;
            }

            string requestId = Guid.NewGuid().ToString();
            var metadata = _lightshipSettings.GetCommonDataEnvelopeWithRequestIdAsStruct(requestId);
            var requestHeaders = Metadata.GetApiGatewayHeaders(requestId);
            requestHeaders.Add("Authorization", _lightshipSettings.ApiKey);

            if (Input.location.status == LocationServiceStatus.Running)
            {
                var distanceToQuery = (int)queryLocation.Distance(new LatLng(Input.location.lastData));
                request = new _CoverageAreasRequest(queryLocation, queryRadius, distanceToQuery, metadata);
            }
            else
            {
                request = new _CoverageAreasRequest(queryLocation, queryRadius, metadata);
            }

            var response =
                await _HttpClient.SendPostAsync<_CoverageAreasRequest, _CoverageAreasResponse>
                (
                    CoverageAreasEndpoint,
                    request,
                    requestHeaders
                );

            if (response.Status == ResponseStatus.Success)
            {
                response.Status = _ResponseStatusTranslator.FromString(response.Data.status);
            }

            var result = new CoverageAreasResult(response);

            return result;
        }

        private async Task<LocalizationTargetsResult> RequestLocalizationTargetsAsync(string[] targetIdentifiers)
        {
            string requestId = Guid.NewGuid().ToString();
            var metadata = _lightshipSettings.GetCommonDataEnvelopeWithRequestIdAsStruct(requestId);
            var requestHeaders = Metadata.GetApiGatewayHeaders(requestId);
            requestHeaders.Add("Authorization", _lightshipSettings.ApiKey);

            var request = new _LocalizationTargetsRequest(targetIdentifiers, metadata);

            var response =
                await _HttpClient.SendPostAsync<_LocalizationTargetsRequest, _LocalizationTargetsResponse>
                (
                    LocalizationTargetsEndpoint,
                    request,
                    requestHeaders
                );

            if (response.Status == ResponseStatus.Success)
            {
                response.Status = _ResponseStatusTranslator.FromString(response.Data.status);
            }

            var result = new LocalizationTargetsResult(response);

            return result;
        }

        public async void TryGetCoverageAreas(LatLng queryLocation, int queryRadius,
            Action<CoverageAreasResult> onAreasReceived)
        {
            var result = await RequestCoverageAreasAsync(queryLocation, queryRadius);
            onAreasReceived?.Invoke(result);
        }

        public async void TryGetLocalizationTargets(string[] targetIdentifiers,
            Action<LocalizationTargetsResult> onTargetsReceived)
        {
            var result = await RequestLocalizationTargetsAsync(targetIdentifiers);
            onTargetsReceived?.Invoke(result);
        }

        public async void TryGetCoverage(LatLng queryLocation, int queryRadius,
            Action<AreaTargetsResult> onLocationsReceived, LocalizationTarget[] privateScanLocalizationTargets = null)
        {
            var areasResult = await RequestCoverageAreasAsync(queryLocation, queryRadius);
            LocalizationTargetsResult targetsResult = null;

            if (areasResult.Status == ResponseStatus.Success)
            {
                var targetIds = new List<string>();
                foreach (var area in areasResult.Areas)
                {
                    foreach (string target in area.LocalizationTargetIdentifiers)
                    {
                        targetIds.Add(target);
                    }
                }

                targetsResult = await RequestLocalizationTargetsAsync(targetIds.ToArray());
            }

            var responseStatus = targetsResult?.Status ?? areasResult.Status;
            var locationsResult = new AreaTargetsResult(queryLocation, queryRadius, responseStatus, areasResult,
                targetsResult, privateScanLocalizationTargets);
            onLocationsReceived?.Invoke(locationsResult);
        }

        /// Downloads the image from the provided url as a texture, using the async await pattern.
        /// @param onImageReceived Callback for downloaded image as texture. When download fails,
        /// texture is returned as null.
        public async Task<Texture> TryGetImageFromUrl(string imageUrl)
        {
            var image = await _HttpClient.DownloadImageAsync(imageUrl);
            return image;
        }

        /// Downloads the image from the provided url as a texture, using the callback pattern.
        /// @param onImageReceived Callback for downloaded image as texture. When download fails,
        /// texture is returned as null.
        public async void TryGetImageFromUrl(string imageUrl, Action<Texture> onImageDownloaded)
        {
            var image = await _HttpClient.DownloadImageAsync(imageUrl);
            onImageDownloaded?.Invoke(image);
        }

        /// Downloads the image from the provided url as a texture cropped to a fixed size, using the
        /// async await pattern.
        /// The source image is first resampled so the image is fitting for the limiting dimension, then
        /// it gets cropped to the fixed size.
        /// @param width Fixed width of cropped image
        /// @param height Fixed height of cropped image
        /// @param onImageReceived Callback for downloaded image as texture. When download fails,
        /// texture is returned as null.
        public async Task<Texture> TryGetImageFromUrl(string imageUrl, int width, int height)
        {
            var image = await _HttpClient.DownloadImageAsync(imageUrl + "=w" + width + "-h" + height + "-c");
            return image;
        }

        /// Downloads the image from the provided url as a texture cropped to a fixed size, using the
        /// callback pattern.
        /// The source image is first resampled so the image is fitting for the limiting dimension, then
        /// it gets cropped to the fixed size.
        /// @param width Fixed width of cropped image
        /// @param height Fixed height of cropped image
        /// @param onImageReceived Callback for downloaded image as texture. When download fails,
        /// texture is returned as null.
        public async void TryGetImageFromUrl(string imageUrl, int width, int height, Action<Texture> onImageDownloaded)
        {
            var image = await _HttpClient.DownloadImageAsync(imageUrl + "=w" + width + "-h" + height + "-c");
            onImageDownloaded?.Invoke(image);
        }
    }
}

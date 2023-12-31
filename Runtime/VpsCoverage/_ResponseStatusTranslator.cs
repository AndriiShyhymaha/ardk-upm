// Copyright 2022 Niantic, Inc. All Rights Reserved.

using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.Networking;

namespace Niantic.Lightship.AR
{
    internal static class _ResponseStatusTranslator
    {
        public static ResponseStatus FromString(string status)
        {
            ResponseStatus result;
            if (Enum.TryParse(status, out result))
                return result;

            status = status.ToLower().Replace("_", " ");
            TextInfo info = CultureInfo.CurrentCulture.TextInfo;
            status = info.ToTitleCase(status).Replace(" ", string.Empty);
            Enum.TryParse(status, out result);
            return result;
        }

        public static ResponseStatus FromHttpStatus(UnityWebRequest.Result httpRequestProgressStatus,
            long httpStatusCode)
        {
            Enum.TryParse(httpRequestProgressStatus.ToString(), out ResponseStatus responseStatus);

            if (responseStatus == ResponseStatus.ProtocolError)
            {
                Enum.TryParse(httpStatusCode.ToString(), out responseStatus);
            }

            return responseStatus;
        }
    }
}

﻿/*
 * Copyright (c) 2018 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Tizen.Applications.WatchfaceComplication
{
    /// <summary>
    /// Represents the short text data for a complication.
    /// </summary>
    /// <since_tizen> 6 </since_tizen>
    public class ShortTextData : ComplicationData
    {
        /// <summary>
        /// Initializes a new instance of the ShortTextData class.
        /// </summary>
        /// <param name="shortText">The short text.</param>
        /// <param name="iconPath">The icon path.</param>
        /// <param name="title">The title.</param>
        /// <param name="extraData">The extra data.</param>
        /// <exception cref="ArgumentException">Thrown when parameter is invalid.</exception>
        /// <example>
        /// <code>
        ///     protected override ComplicationData OnDataUpdateRequested(string reqestAppId, ComplicationTypes type, Bundle contextData)
        ///     {
        ///         if (type == ComplicationTypes.ShortText)
        ///         {
        ///             return new ShortTextData("short", "icon path", "title", "extra");
        ///         }
        ///         else if (type == ComplicationTypes.LongText)
        ///         {
        ///             return new LongTextData("longlong", "icon path", "title", null);
        ///         }
        ///     }
        /// </code>
        /// </example>
        /// <since_tizen> 6 </since_tizen>
        public ShortTextData(string shortText, string iconPath, string title, string extraData)
        {
            if (shortText == null)
                ErrorFactory.ThrowException(ComplicationError.InvalidParam, "fail to create short text");
            Type = ComplicationTypes.ShortText;
            ShortText = shortText;
            IconPath = iconPath;
            Title = title;
            ExtraData = extraData;
        }

        /// <summary>
        /// The short text data.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when try to set invalid value.</exception>
        /// <since_tizen> 6 </since_tizen>
        public new string ShortText
        {
            get
            {
                return base.ShortText;
            }
            set
            {
                if (value == null)
                    ErrorFactory.ThrowException(ComplicationError.InvalidParam, "fail to create short text");
                base.ShortText = value;
            }
        }

        /// <summary>
        /// The icon path data.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public new string IconPath
        {
            get
            {
                return base.IconPath;
            }
            set
            {
                base.IconPath = value;
            }
        }

        /// <summary>
        /// The title data.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public new string Title
        {
            get
            {
                return base.Title;
            }
            set
            {
                base.Title = value;
            }
        }

        /// <summary>
        /// The extra data.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public new string ExtraData
        {
            get
            {
                return base.ExtraData;
            }
            set
            {
                base.ExtraData = value;
            }
        }

        /// <summary>
        /// The information about the screen reader text of complication data.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public new string ScreenReaderText
        {
            get
            {
                return base.ScreenReaderText;
            }
            set
            {
                base.ScreenReaderText = value;
            }
        }
    }
}

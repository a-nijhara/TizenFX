/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
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

namespace ElmSharp.Accessible
{
    /// <summary>
    /// Enumeration for ReadingInfoType.
    /// </summary>
    /// <since_tizen> preview </since_tizen>
    [Obsolete("This has been deprecated in API12")]
    [Flags]
    public enum ReadingInfoType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,
        /// <summary>
        /// Name for reading info type.
        /// </summary>
        Name = 0x1,
        /// <summary>
        /// Role for reading info type.
        /// </summary>
        Role = 0x2,
        /// <summary>
        /// Description for reading info type.
        /// </summary>
        Description = 0x4,
        /// <summary>
        /// State for reading info type.
        /// </summary>
        State = 0x8
    }
}

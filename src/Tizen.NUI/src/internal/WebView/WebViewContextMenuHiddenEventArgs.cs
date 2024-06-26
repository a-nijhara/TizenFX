/*
 * Copyright (c) 2021 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

using System;
using System.ComponentModel;

namespace Tizen.NUI
{
    /// <summary>
    /// Event arguments that passed via the WebView.ContextMenuHidden.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class WebViewContextMenuHiddenEventArgs : EventArgs
    {
        internal WebViewContextMenuHiddenEventArgs(WebContextMenu menu)
        {
            ContextMenu = menu;
        }

        /// <summary>
        /// The context menu that is hidden.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebContextMenu ContextMenu { get; }
    }
}

// Copyright 2016 by Samsung Electronics, Inc.,
//
// This software is the confidential and proprietary information
// of Samsung Electronics, Inc. ("Confidential Information"). You
// shall not disclose such Confidential Information and shall use
// it only in accordance with the terms of the license agreement
// you entered into with Samsung.

using System;
using System.Runtime.InteropServices;

using Tizen.Applications;

internal static partial class Interop
{
    internal static partial class MessagePort
    {
        [DllImport(Libraries.MessagePort, EntryPoint = "message_port_register_local_port", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int RegisterPort(string local_port, message_port_message_cb callback, IntPtr userData);

        [DllImport(Libraries.MessagePort, EntryPoint = "message_port_register_trusted_local_port", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int RegisterTrustedPort(string trusted_local_port, message_port_message_cb callback, IntPtr userData);

        [DllImport(Libraries.MessagePort, EntryPoint = "message_port_unregister_local_port", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UnregisterPort(int local_port_id);

        [DllImport(Libraries.MessagePort, EntryPoint = "message_port_unregister_trusted_local_port", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UnregisterTrustedPort(int trusted_local_port_id);

        [DllImport(Libraries.MessagePort, EntryPoint = "message_port_send_message_with_local_port", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int SendMessageWithLocalPort(string remote_app_id, string remote_port, SafeBundleHandle message, int local_port_id);

        [DllImport(Libraries.MessagePort, EntryPoint = "message_port_send_trusted_message_with_local_port", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int SendTrustedMessageWithLocalPort(string remote_app_id, string remote_port, SafeBundleHandle message, int local_port_id);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void message_port_message_cb(int local_port_id, string remote_app_id, string remote_port, bool trusted_remote_port, IntPtr message, IntPtr userData);
    }
}

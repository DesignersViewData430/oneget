﻿// 
//  Copyright (c) Microsoft Corporation. All rights reserved. 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  

namespace Microsoft.OneGet {
    internal static class Constants {
        internal const string MSGPrefix = "MSG:";
        internal const string FailedProviderBootstrap = "MSG:FailedProviderBootstrap";
        internal const string UnknownProvider = "MSG:UnknownProvider";
        internal const string UserDeclinedUntrustedPackageInstall = "MSG:UserDeclinedUntrustedPackageInstall";

        internal const string Installed = "Installed";
        internal const string Uninstalled = "Uninstalled";

        internal const string ProviderPluginLoadFailure = "MSG:ProviderPluginLoadFailure";
        internal const string Invalidoperation = "InvalidOperation";

        internal const string MinVersion = "0.0.0.1";
    }
}
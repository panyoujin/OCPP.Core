﻿/*
 * OCPP.Core - https://github.com/dallmann-consulting/OCPP.Core
 * Copyright (C) 2020-2021 dallmann consulting GmbH.
 * All Rights Reserved.
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCPP.Core.Server.Messages
{
    /// <summary>
    /// Warpper object for OCPP Message
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Message type
        /// </summary>
        public string MessageType { get; set; }

        /// <summary>
        /// Message ID
        /// </summary>
        public string UniqueId { get; set; }

        /// <summary>
        /// Action
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// JSON-Payload
        /// </summary>
        public string JsonPayload { get; set; }

        /// <summary>
        /// Error-Code
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error-Description
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Message()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Message(string messageType, string uniqueId, string action, string jsonPayload)
        {
            MessageType = messageType;
            UniqueId = uniqueId;
            Action = action;
            JsonPayload = jsonPayload;
        }
    }
}

/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Green;
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170823;

namespace Aliyun.Acs.Green.Model.V20170823
{
    public class DeleteNotificationContactsRequest : RpcAcsRequest<DeleteNotificationContactsResponse>
    {
        public DeleteNotificationContactsRequest()
            : base("Green", "2017-08-23", "DeleteNotificationContacts")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string contactTypes;

		private string sourceIp;

		private string lang;

		public string ContactTypes
		{
			get
			{
				return contactTypes;
			}
			set	
			{
				contactTypes = value;
				DictionaryUtil.Add(QueryParameters, "ContactTypes", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteNotificationContactsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteNotificationContactsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

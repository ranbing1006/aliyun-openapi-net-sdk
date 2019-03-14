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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class GetUserOutputStatisticInfoResponse : AcsResponse
	{

		private string requestId;

		private List<GetUserOutputStatisticInfo_ClusterStatUserOutput> userOutputList;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<GetUserOutputStatisticInfo_ClusterStatUserOutput> UserOutputList
		{
			get
			{
				return userOutputList;
			}
			set	
			{
				userOutputList = value;
			}
		}

		public class GetUserOutputStatisticInfo_ClusterStatUserOutput
		{

			private string user;

			private long? bytesOutput;

			public string User
			{
				get
				{
					return user;
				}
				set	
				{
					user = value;
				}
			}

			public long? BytesOutput
			{
				get
				{
					return bytesOutput;
				}
				set	
				{
					bytesOutput = value;
				}
			}
		}
	}
}
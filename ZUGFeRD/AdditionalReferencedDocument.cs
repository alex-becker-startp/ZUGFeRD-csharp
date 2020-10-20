/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2industries.ZUGFeRD
{
    /// <summary>
    /// Reference documents are supposed to hold additional data you might want to show on item level.
    /// 
    /// Reference documents are used e.g. for commissions on item level
    /// </summary>
    public class AdditionalReferencedDocument : BaseReferencedDocument
    {
        /// <summary>
        /// Reference documents are strongly typed, specify ReferenceTypeCode to allow easy processing by invoicee
        /// </summary>
        public ReferenceTypeCodes ReferenceTypeCode { get; set; }

        /// <summary>
        /// The identifier of the tendering or batch the invoice refers to, or an identifier for an object 
        /// given by the seller the invoice refers to, or an identifier of the documents substantiating the invoice.
        /// </summary>
        public string IssuerAssignedID { get; set; }

        /// <summary>
        /// Description of document
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// An attached document embedded as binary object or sent together with the invoice.
        /// </summary>
        public byte[] AttachmentBinaryObject { get; set; } = null;

        /// <summary>
        /// Filename of attachment
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        /// Type of the reference document
        /// </summary>
        public AdditionalReferencedDocumentTypeCode TypeCode { get; set; }
    }
}

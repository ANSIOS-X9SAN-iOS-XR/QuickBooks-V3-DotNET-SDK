﻿////*********************************************************
// <copyright file="SecurityException.cs" company="Microsoft">
/*******************************************************************************
 * Copyright 2016 Intuit
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *******************************************************************************/
// <summary>This file contains SdkException.</summary>
// <summary>This file contains SecurityException.</summary>
////*********************************************************

namespace Intuit.Ipp.Exception
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Runtime.Serialization;
    using Intuit.Ipp.Exception.Properties;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    [System.Serializable]
    public class SecurityException : IdsException
    {
       


        /// <summary>
        /// Initializes a new instance of the SecurityException class.
        /// </summary>
        /// <param name="innerExceptions">Inner Exceptions.</param>
        public SecurityException(IList<IdsError> innerExceptions)
            : base(Resources.SecurityExceptionDefaultMessage, innerExceptions)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SecurityException class.
        /// </summary>
        public SecurityException()
            : base(Resources.SecurityExceptionDefaultMessage)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SecurityException class.
        /// </summary>
        /// <param name="errorMessage">Error Message.</param>
        public SecurityException(string errorMessage)
            : base(errorMessage)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SecurityException class.
        /// </summary>
        /// <param name="errorMessage">Error Message</param>
        /// <param name="innerException">Inner Exception.</param>
        public SecurityException(string errorMessage, System.Exception innerException)
            : base(errorMessage, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SecurityException class.
        /// </summary>
        /// <param name="errorMessage">Error Message</param>
        /// <param name="errorCode">Error Code.</param>
        /// <param name="source">Source of the exception.</param>
        public SecurityException(string errorMessage, string errorCode, string source)
            : base(errorMessage, errorCode, source)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SecurityException class.
        /// </summary>
        /// <param name="errorMessage">Error Message</param>
        /// <param name="errorCode">Error Code.</param>
        /// <param name="source">Source of the exception.</param>
        /// <param name="innerException">Inner Exception.</param>
        public SecurityException(string errorMessage, string errorCode, string source, System.Exception innerException)
            : base(errorMessage, errorCode, source, innerException)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the SecurityException class.
        /// </summary>
        /// <param name="info">The System.Runtime.Serialization.SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The System.Runtime.Serialization.StreamingContext that contains contextual information about the source or destination.</param>
        protected SecurityException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}

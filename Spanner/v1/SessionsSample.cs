﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  methodTemplate.tt
//     Build date: 07/06/2017 15:31:23
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Spanner v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Cloud Spanner is a managed, mission-critical, globally consistent and scalable relational database service.
// API Documentation Link https://cloud.google.com/spanner/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Spanner/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Spanner.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Spanner.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Spanner.v1;
using Google.Apis.Spanner.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Spannerv1.Methods
{
  
    public static class SessionsSample
    {


        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.This is mainly useful for determining whether a session is stillalive. 
        /// Documentation https://developers.google.com/spanner/v1/reference/sessions/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spanner service.</param>  
        /// <param name="name">Required. The name of the session to retrieve.</param>
        /// <returns>SessionResponse</returns>
        public static Session Get(SpannerService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Sessions.Get(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sessions.Get failed.", ex);
            }
        }

        /// <summary>
        /// Commits a transaction. The request includes the mutations to beapplied to rows in the database.`Commit` might return an `ABORTED` error. This can occur at any time;commonly, the cause is conflicts with concurrenttransactions. However, it can also happen for a variety of otherreasons. If `Commit` returns `ABORTED`, the caller should re-attemptthe transaction from the beginning, re-using the same session. 
        /// Documentation https://developers.google.com/spanner/v1/reference/sessions/commit
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spanner service.</param>  
        /// <param name="session">Required. The session in which the transaction to be committed is running.</param>
        /// <param name="body">A valid Spanner v1 body.</param>
        /// <returns>CommitResponseResponse</returns>
        public static CommitResponse Commit(SpannerService service, string session, CommitRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (session == null)
                    throw new ArgumentNullException(session);

                // Make the request.
                return service.Sessions.Commit(body, session).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sessions.Commit failed.", ex);
            }
        }

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:Read, ExecuteSql andCommit can begin a new transaction as aside-effect. 
        /// Documentation https://developers.google.com/spanner/v1/reference/sessions/beginTransaction
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spanner service.</param>  
        /// <param name="session">Required. The session in which the transaction runs.</param>
        /// <param name="body">A valid Spanner v1 body.</param>
        /// <returns>TransactionResponse</returns>
        public static Transaction BeginTransaction(SpannerService service, string session, BeginTransactionRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (session == null)
                    throw new ArgumentNullException(session);

                // Make the request.
                return service.Sessions.BeginTransaction(body, session).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sessions.BeginTransaction failed.", ex);
            }
        }

        /// <summary>
        /// Ends a session, releasing server resources associated with it. 
        /// Documentation https://developers.google.com/spanner/v1/reference/sessions/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spanner service.</param>  
        /// <param name="name">Required. The name of the session to delete.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(SpannerService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Sessions.Delete(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sessions.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Like ExecuteSql, except returns the resultset as a stream. Unlike ExecuteSql, thereis no limit on the size of the returned result set. However, noindividual row in the result set can exceed 100 MiB, and nocolumn value can exceed 10 MiB. 
        /// Documentation https://developers.google.com/spanner/v1/reference/sessions/executeStreamingSql
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spanner service.</param>  
        /// <param name="session">Required. The session in which the SQL query should be performed.</param>
        /// <param name="body">A valid Spanner v1 body.</param>
        /// <returns>PartialResultSetResponse</returns>
        public static PartialResultSet ExecuteStreamingSql(SpannerService service, string session, ExecuteSqlRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (session == null)
                    throw new ArgumentNullException(session);

                // Make the request.
                return service.Sessions.ExecuteStreamingSql(body, session).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sessions.ExecuteStreamingSql failed.", ex);
            }
        }

        /// <summary>
        /// Executes an SQL query, returning all rows in a single reply. Thismethod cannot be used to return a result set larger than 10 MiB;if the query yields more data than that, the query fails witha `FAILED_PRECONDITION` error.Queries inside read-write transactions might return `ABORTED`. Ifthis occurs, the application should restart the transaction fromthe beginning. See Transaction for more details.Larger result sets can be fetched in streaming fashion by callingExecuteStreamingSql instead. 
        /// Documentation https://developers.google.com/spanner/v1/reference/sessions/executeSql
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spanner service.</param>  
        /// <param name="session">Required. The session in which the SQL query should be performed.</param>
        /// <param name="body">A valid Spanner v1 body.</param>
        /// <returns>ResultSetResponse</returns>
        public static ResultSet ExecuteSql(SpannerService service, string session, ExecuteSqlRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (session == null)
                    throw new ArgumentNullException(session);

                // Make the request.
                return service.Sessions.ExecuteSql(body, session).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sessions.ExecuteSql failed.", ex);
            }
        }

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a goodidea to call this for any transaction that includes one or moreRead or ExecuteSql requests andultimately decides not to commit.`Rollback` returns `OK` if it successfully aborts the transaction, thetransaction was already aborted, or the transaction is notfound. `Rollback` never returns `ABORTED`. 
        /// Documentation https://developers.google.com/spanner/v1/reference/sessions/rollback
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spanner service.</param>  
        /// <param name="session">Required. The session in which the transaction to roll back is running.</param>
        /// <param name="body">A valid Spanner v1 body.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Rollback(SpannerService service, string session, RollbackRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (session == null)
                    throw new ArgumentNullException(session);

                // Make the request.
                return service.Sessions.Rollback(body, session).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sessions.Rollback failed.", ex);
            }
        }

        /// <summary>
        /// Like Read, except returns the result set as astream. Unlike Read, there is no limit on thesize of the returned result set. However, no individual row inthe result set can exceed 100 MiB, and no column value can exceed10 MiB. 
        /// Documentation https://developers.google.com/spanner/v1/reference/sessions/streamingRead
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spanner service.</param>  
        /// <param name="session">Required. The session in which the read should be performed.</param>
        /// <param name="body">A valid Spanner v1 body.</param>
        /// <returns>PartialResultSetResponse</returns>
        public static PartialResultSet StreamingRead(SpannerService service, string session, ReadRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (session == null)
                    throw new ArgumentNullException(session);

                // Make the request.
                return service.Sessions.StreamingRead(body, session).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sessions.StreamingRead failed.", ex);
            }
        }

        /// <summary>
        /// Creates a new session. A session can be used to performtransactions that read and/or modify data in a Cloud Spanner database.Sessions are meant to be reused for many consecutivetransactions.Sessions can only execute one transaction at a time. To executemultiple concurrent read-write/write-only transactions, createmultiple sessions. Note that standalone reads and queries use atransaction internally, and count toward the one transactionlimit.Cloud Spanner limits the number of sessions that can exist at any giventime; thus, it is a good idea to delete idle and/or unneeded sessions.Aside from explicit deletes, Cloud Spanner can delete sessions for which nooperations are sent for more than an hour. If a session is deleted,requests to it return `NOT_FOUND`.Idle sessions can be kept alive by sending a trivial SQL queryperiodically, e.g., `"SELECT 1"`. 
        /// Documentation https://developers.google.com/spanner/v1/reference/sessions/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spanner service.</param>  
        /// <param name="database">Required. The database in which the new session is created.</param>
        /// <returns>SessionResponse</returns>
        public static Session Create(SpannerService service, string database)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (database == null)
                    throw new ArgumentNullException(database);

                // Make the request.
                return service.Sessions.Create(database).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sessions.Create failed.", ex);
            }
        }

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as asimple key/value style alternative toExecuteSql.  This method cannot be used toreturn a result set larger than 10 MiB; if the read matches moredata than that, the read fails with a `FAILED_PRECONDITION`error.Reads inside read-write transactions might return `ABORTED`. Ifthis occurs, the application should restart the transaction fromthe beginning. See Transaction for more details.Larger result sets can be yielded in streaming fashion by callingStreamingRead instead. 
        /// Documentation https://developers.google.com/spanner/v1/reference/sessions/read
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spanner service.</param>  
        /// <param name="session">Required. The session in which the read should be performed.</param>
        /// <param name="body">A valid Spanner v1 body.</param>
        /// <returns>ResultSetResponse</returns>
        public static ResultSet Read(SpannerService service, string session, ReadRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (session == null)
                    throw new ArgumentNullException(session);

                // Make the request.
                return service.Sessions.Read(body, session).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sessions.Read failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}
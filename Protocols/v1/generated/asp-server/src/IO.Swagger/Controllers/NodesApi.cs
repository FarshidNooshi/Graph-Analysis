/*
 * PolarisApi
 *
 * This is the api for Polaris Data Analysis Project on  [PolarisGithub](https://github.com/Star-Academy/StarAcademy-Group2/) 
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class NodesApiController : ControllerBase
    { 
        /// <summary>
        /// Add a new Node to the dataset
        /// </summary>
        /// <param name="body">Node object to be sent</param>
        /// <response code="201">Created</response>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/api/v1/nodes")]
        [ValidateModelState]
        [SwaggerOperation("AddNode")]
        public virtual IActionResult AddNode([FromBody]Node body)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201);

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete Nodes by id
        /// </summary>
        /// <param name="nodeId">Node id to delete</param>
        /// <response code="200">success</response>
        /// <response code="404">node not found</response>
        [HttpDelete]
        [Route("/api/v1/nodes/{nodeId}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteNodeById")]
        public virtual IActionResult DeleteNodeById([FromRoute][Required]string nodeId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Nodes by id
        /// </summary>
        /// <remarks>Returns a single Node</remarks>
        /// <param name="nodeId">Id of the Node to return</param>
        /// <response code="200">success</response>
        /// <response code="404">Node not found</response>
        [HttpGet]
        [Route("/api/v1/nodes/{nodeId}")]
        [ValidateModelState]
        [SwaggerOperation("GetNodeById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Node), description: "success")]
        public virtual IActionResult GetNodeById([FromRoute][Required]string nodeId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Node));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"id\" : \"6000000198\",\n  \"data\" : {\n    \"cardId\" : \"6104340000000000\",\n    \"sheba\" : \"IR120778801496000000198\",\n    \"accountType\" : \"پس انداز\",\n    \"branchTelephone\" : \"55638667\",\n    \"branchAdress\" : \"تهران-خیابان خیام-بالاتر از چهارراه گلوبندک\",\n    \"branchName\" : \"گلوبندک\",\n    \"ownerName\" : \"افسر\",\n    \"ownerFamilyName\" : \"طباطبایی\",\n    \"ownerId\" : \"1227114110\"\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Node>(exampleJson)
                        : default(Node);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get Node(s)
        /// </summary>
        /// <param name="filter">Filter on Nodes in [\&quot;{field} {operator} {value}\&quot;, ...] format</param>
        /// <param name="pageIndex">Pagination pageIndex</param>
        /// <param name="pageSize">Pagination pageSize</param>
        /// <response code="200">success</response>
        [HttpGet]
        [Route("/api/v1/nodes")]
        [ValidateModelState]
        [SwaggerOperation("GetNodes")]
        [SwaggerResponse(statusCode: 200, type: typeof(NodeCollection), description: "success")]
        public virtual IActionResult GetNodes([FromQuery]Graph filter, [FromQuery]int? pageIndex, [FromQuery]int? pageSize)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(NodeCollection));
            string exampleJson = null;
            exampleJson = "[ {\n  \"id\" : \"6000000198\",\n  \"data\" : {\n    \"cardId\" : \"6104340000000000\",\n    \"sheba\" : \"IR120778801496000000198\",\n    \"accountType\" : \"پس انداز\",\n    \"branchTelephone\" : \"55638667\",\n    \"branchAdress\" : \"تهران-خیابان خیام-بالاتر از چهارراه گلوبندک\",\n    \"branchName\" : \"گلوبندک\",\n    \"ownerName\" : \"افسر\",\n    \"ownerFamilyName\" : \"طباطبایی\",\n    \"ownerId\" : \"1227114110\"\n  }\n}, {\n  \"id\" : \"6000000198\",\n  \"data\" : {\n    \"cardId\" : \"6104340000000000\",\n    \"sheba\" : \"IR120778801496000000198\",\n    \"accountType\" : \"پس انداز\",\n    \"branchTelephone\" : \"55638667\",\n    \"branchAdress\" : \"تهران-خیابان خیام-بالاتر از چهارراه گلوبندک\",\n    \"branchName\" : \"گلوبندک\",\n    \"ownerName\" : \"افسر\",\n    \"ownerFamilyName\" : \"طباطبایی\",\n    \"ownerId\" : \"1227114110\"\n  }\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<NodeCollection>(exampleJson)
                        : default(NodeCollection);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get the typing of the nodes
        /// </summary>
        /// <response code="200">success</response>
        [HttpGet]
        [Route("/api/v1/nodes/typing")]
        [ValidateModelState]
        [SwaggerOperation("GetNodesTyping")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Typing>), description: "success")]
        public virtual IActionResult GetNodesTyping()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Typing>));
            string exampleJson = null;
            exampleJson = "[ {\n  \"field\" : \"field\",\n  \"_type\" : \"_type\"\n}, {\n  \"field\" : \"field\",\n  \"_type\" : \"_type\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Typing>>(exampleJson)
                        : default(List<Typing>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update an existing Node
        /// </summary>
        /// <param name="body">Node object to be sent</param>
        /// <response code="200">Updated</response>
        /// <response code="404">Node not found</response>
        /// <response code="405">Invalid input</response>
        [HttpPut]
        [Route("/api/v1/nodes")]
        [ValidateModelState]
        [SwaggerOperation("UpdateNode")]
        public virtual IActionResult UpdateNode([FromBody]Node body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);

            throw new NotImplementedException();
        }
    }
}

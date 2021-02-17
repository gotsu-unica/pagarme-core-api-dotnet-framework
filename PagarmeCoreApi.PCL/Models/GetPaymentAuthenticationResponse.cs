/*
 * PagarmeCoreApi.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PagarmeCoreApi.PCL;
using PagarmeCoreApi.PCL.Utilities;


namespace PagarmeCoreApi.PCL.Models
{
    public class GetPaymentAuthenticationResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string type;
        private Models.GetThreeDSecureResponse threedSecure;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// 3D-S payment authentication response
        /// </summary>
        [JsonProperty("threed_secure")]
        public Models.GetThreeDSecureResponse ThreedSecure 
        { 
            get 
            {
                return this.threedSecure; 
            } 
            set 
            {
                this.threedSecure = value;
                onPropertyChanged("ThreedSecure");
            }
        }
    }
} 
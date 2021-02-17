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
    public class CreateDebitCardPaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string statementDescriptor;
        private Models.CreateCardRequest card;
        private string cardId;
        private string cardToken;
        private bool? recurrence;
        private Models.CreatePaymentAuthenticationRequest authentication;
        private Models.CreateCardPaymentContactlessRequest token;

        /// <summary>
        /// The text that will be shown on the debit card's statement
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor 
        { 
            get 
            {
                return this.statementDescriptor; 
            } 
            set 
            {
                this.statementDescriptor = value;
                onPropertyChanged("StatementDescriptor");
            }
        }

        /// <summary>
        /// Debit card data
        /// </summary>
        [JsonProperty("card")]
        public Models.CreateCardRequest Card 
        { 
            get 
            {
                return this.card; 
            } 
            set 
            {
                this.card = value;
                onPropertyChanged("Card");
            }
        }

        /// <summary>
        /// The debit card id
        /// </summary>
        [JsonProperty("card_id")]
        public string CardId 
        { 
            get 
            {
                return this.cardId; 
            } 
            set 
            {
                this.cardId = value;
                onPropertyChanged("CardId");
            }
        }

        /// <summary>
        /// The debit card token
        /// </summary>
        [JsonProperty("card_token")]
        public string CardToken 
        { 
            get 
            {
                return this.cardToken; 
            } 
            set 
            {
                this.cardToken = value;
                onPropertyChanged("CardToken");
            }
        }

        /// <summary>
        /// Indicates a recurrence
        /// </summary>
        [JsonProperty("recurrence")]
        public bool? Recurrence 
        { 
            get 
            {
                return this.recurrence; 
            } 
            set 
            {
                this.recurrence = value;
                onPropertyChanged("Recurrence");
            }
        }

        /// <summary>
        /// The payment authentication request
        /// </summary>
        [JsonProperty("authentication")]
        public Models.CreatePaymentAuthenticationRequest Authentication 
        { 
            get 
            {
                return this.authentication; 
            } 
            set 
            {
                this.authentication = value;
                onPropertyChanged("Authentication");
            }
        }

        /// <summary>
        /// The Debit card payment token request
        /// </summary>
        [JsonProperty("token")]
        public Models.CreateCardPaymentContactlessRequest Token 
        { 
            get 
            {
                return this.token; 
            } 
            set 
            {
                this.token = value;
                onPropertyChanged("Token");
            }
        }
    }
} 
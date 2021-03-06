// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The SupportRequest action.
    /// </summary>
    public partial class SupportRequestAction
    {
        /// <summary>
        /// Initializes a new instance of the SupportRequestAction class.
        /// </summary>
        public SupportRequestAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SupportRequestAction class.
        /// </summary>
        /// <param name="severity">The support request severity.</param>
        /// <param name="firstName">The first name of the recipient.</param>
        /// <param name="lastName">The last name of the recipient.</param>
        /// <param name="country">The country of the recipient.</param>
        /// <param name="phoneNumber">The phone number of the
        /// recipient.</param>
        /// <param name="primaryEmailAddress">The primary email addresses of
        /// the recipients.</param>
        /// <param name="supportLanguage">The support language.</param>
        /// <param name="preferredContactMethod">The preferred communication
        /// channel.</param>
        /// <param name="alternateEmailAddresses">The alternate email address
        /// of the recipient.</param>
        public SupportRequestAction(object severity = default(object), string firstName = default(string), string lastName = default(string), string country = default(string), string phoneNumber = default(string), string primaryEmailAddress = default(string), string supportLanguage = default(string), object preferredContactMethod = default(object), IList<string> alternateEmailAddresses = default(IList<string>))
        {
            Severity = severity;
            FirstName = firstName;
            LastName = lastName;
            Country = country;
            PhoneNumber = phoneNumber;
            PrimaryEmailAddress = primaryEmailAddress;
            SupportLanguage = supportLanguage;
            PreferredContactMethod = preferredContactMethod;
            AlternateEmailAddresses = alternateEmailAddresses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the support request severity.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public object Severity { get; set; }

        /// <summary>
        /// Gets or sets the first name of the recipient.
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the recipient.
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the country of the recipient.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the recipient.
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the primary email addresses of the recipients.
        /// </summary>
        [JsonProperty(PropertyName = "primaryEmailAddress")]
        public string PrimaryEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the support language.
        /// </summary>
        [JsonProperty(PropertyName = "supportLanguage")]
        public string SupportLanguage { get; set; }

        /// <summary>
        /// Gets or sets the preferred communication channel.
        /// </summary>
        [JsonProperty(PropertyName = "preferredContactMethod")]
        public object PreferredContactMethod { get; set; }

        /// <summary>
        /// Gets or sets the alternate email address of the recipient.
        /// </summary>
        [JsonProperty(PropertyName = "alternateEmailAddresses")]
        public IList<string> AlternateEmailAddresses { get; set; }

    }
}

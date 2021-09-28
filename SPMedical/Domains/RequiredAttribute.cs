using System;

namespace SPMedical.Domains
{
    internal class RequiredAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
}
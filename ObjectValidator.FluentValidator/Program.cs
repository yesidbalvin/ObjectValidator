using ObjectValidator.Domain.ConfirmedViolationCreated;
using ObjectValidator.FluentValidator.MetadataValidator;
using ObjectValidator.FluentValidator.Validator;
using System;
using System.IO;
using System.Text.Json;

namespace ObjectValidator.FluentValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Fluent Validation
             * 1. Valid object, Data\ValidCV.json
             */
            // Custom validator simulating the Certificate of Integrity
            Console.WriteLine("***********************************");
            Console.WriteLine("Valid CV");

            var confirmedViolationCreated = GetConfirmedViolationCreated(@"Data/ValidCV.json");
            var confirmedViolationCreatedValidator = new ConfirmedViolationCreatedValidator();
            var results = confirmedViolationCreatedValidator.Validate(confirmedViolationCreated);
            if (!results.IsValid)
            {
                Console.WriteLine($"Error Validating ConfirmedViolationCreated => {results.ToString()}");
                //foreach (var item in results.Errors)
                //{
                //    Console.WriteLine($"Property {item.PropertyName} failed, with error {item.ErrorMessage}");
                //}
            }
            else
            {
                Console.WriteLine(@"The object Data\ValidCV.json is valid");
            }
            /*
             * Fluent Validation
             * 2. Invalid Object, No PotentialViolations, Data\InvalidCV-noPV.json
             */
            Console.WriteLine("***********************************");
            Console.WriteLine("Invalid CV with no Potential Violation");

            confirmedViolationCreated = GetConfirmedViolationCreated(@"Data/InvalidCV_noPV.json");
            results = confirmedViolationCreatedValidator.Validate(confirmedViolationCreated);
            if (!results.IsValid)
            {
                Console.WriteLine($"Error validting ConfirmedViolationCretead => {results.ToString()}");
            }
            else
            {
                Console.WriteLine(@"The object Data\InvalidCV_noPV.json is valid");
            }

            /*
             * Fluent Validation
             * 3. Invalid Object, missing properties, Data\InvalidCV-missingdata.json
             */
            Console.WriteLine("***********************************");
            Console.WriteLine("Invalid CV with missing properties in PotentialViolation");

            confirmedViolationCreated = GetConfirmedViolationCreated(@"Data/InvalidCV-missingdata.json");
            results = confirmedViolationCreatedValidator.Validate(confirmedViolationCreated);
            if (!results.IsValid)
            {
                Console.WriteLine($"Error validting ConfirmedViolationCretead => {results.ToString()}");
            }
            else
            {
                Console.WriteLine(@"The object Data\InvalidCV-missingdata.json is valid");
            }

            //Custom validator simulating the Metadata file
            //1. Valid object
            confirmedViolationCreated = GetConfirmedViolationCreated(@"Metadata_Data/ValidCV.json");
            var confirmedViolationMetadataValidator = new ConfirmedViolationMetadataValidator();
            results = confirmedViolationMetadataValidator.Validate(confirmedViolationCreated);
            if (!results.IsValid)
            {
                Console.WriteLine($"Error validating metadata => {results.ToString()}");
            }
            else
            {
                Console.WriteLine("@The object Metadata_Data/ValidCV.json is valid");
            }

            //2.Invalid Object, missing CV Id and PV
            confirmedViolationCreated = GetConfirmedViolationCreated(@"Metadata_Data/InvalidCV_noPV.json");
            confirmedViolationMetadataValidator = new ConfirmedViolationMetadataValidator();
            results = confirmedViolationMetadataValidator.Validate(confirmedViolationCreated);
            if (!results.IsValid)
            {
                Console.WriteLine($"Error validating metadata => {results.ToString()}");
            }
            else
            {
                Console.WriteLine("@The object Metadata_Data/InvalidCV_noPV.json is valid");
            }

            //3. Invalid Object, missing PV data
            confirmedViolationCreated = GetConfirmedViolationCreated(@"Metadata_Data/InvalidCV-missingdata.json");
            confirmedViolationMetadataValidator = new ConfirmedViolationMetadataValidator();
            results = confirmedViolationMetadataValidator.Validate(confirmedViolationCreated);
            if (!results.IsValid)
            {
                Console.WriteLine($"Error validating metadata => {results.ToString()}");
            }
            else
            {
                Console.WriteLine("@The object Metadata_Data/InvalidCV-missingdata.json is valid");
            }
        }

        public static ConfirmedViolationCreated GetConfirmedViolationCreated(string cvPath)
        {
            var cvFile = File.ReadAllText(cvPath);
            return JsonSerializer.Deserialize<ConfirmedViolationCreated>(cvFile);
        }
    }
}

using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using Motip.Web.AzureMobileService.Migrations;
using Motip.Web.AzureMobileService.Models;

namespace Motip.Web.AzureMobileService
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            // Use this class to set configuration options for your mobile service
            var options = new ConfigOptions();

            // Use this class to set WebAPI configuration options
            var config = ServiceConfig.Initialize(new ConfigBuilder(options));
            config.SetIsHosted(false);

            // To display errors in the browser during development, uncomment the following
            // line. Comment it out again when you deploy your service for production use.
            // config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
            //Database.SetInitializer(new MobileServiceInitializer());

            var migrator = new DbMigrator(new Configuration());
            string errorMessage = null;
            try
            {
                migrator.Update();
            }
            catch (DbEntityValidationException ex)
            {
                errorMessage = ex.EntityValidationErrors.SelectMany(entityValidationError => entityValidationError.ValidationErrors).Aggregate(errorMessage, (current, dbValidationError) => current + (dbValidationError.PropertyName + ": " + dbValidationError.ErrorMessage + " "));
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            if (errorMessage != null) throw new Exception(errorMessage);
        }
    }

    public class MobileServiceInitializer : DropCreateDatabaseIfModelChanges<MobileServiceContext>
    {
        protected override void Seed(MobileServiceContext context)
        {
            base.Seed(context);
        }
    }
}


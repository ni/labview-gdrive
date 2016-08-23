using System;
using System.Globalization;
using NationalInstruments.Licensing.ClientAdapter;

namespace TestLoaderApplication {
    class Program {
        [STAThread]
        static void Main (string[] args) {
            // Create a client instance
            Client client = new Client(CultureInfo.InvariantCulture);

            // Check if guest blocked
            bool isBlockedGuest = client.IsBlockedGuest(false);
            Console.WriteLine("Guest blocked: {0}", isBlockedGuest);

            // Checkout requests
            CheckoutRequest testStandCheckoutRequest = new CheckoutRequest("TestStand_InstEngine", new NationalInstruments.Licensing.ClientAdapter.Version(16, 0, 0));
            CheckoutRequest dataFinderCheckoutRequest = new CheckoutRequest("DataFinderSE_15Users", new NationalInstruments.Licensing.ClientAdapter.Version(3, 0, 0));
            CheckoutRequest[] requests = new CheckoutRequest[] {testStandCheckoutRequest, dataFinderCheckoutRequest};

            // Attempt checkout
            // client.Checkout(new CheckoutRequest[] { checkoutRequest }, DemoStartMode.DoNotBeginDemo);

            // Request activation through wizard
            var wizardMode = WizardMode.ActivateRequest;
            CustomWizardInfo wizardInfo = new CustomWizardInfo(wizardMode, "DataFinder/TestStand", new NationalInstruments.Licensing.ClientAdapter.Version(3, 0, 0), DemoStartMode.DoNotBeginDemo);
            CheckoutResults results = client.StartLicensingWizard(new CheckoutRequest[] { testStandCheckoutRequest, dataFinderCheckoutRequest }, wizardInfo, CultureInfo.CurrentCulture);
            // Results
            Console.WriteLine("Post wizard - ");
            Console.WriteLine("AllSuccessful: {0}", results.AllSuccessful);
            Console.WriteLine("TestStand status: {0}", results.GetStatus(testStandCheckoutRequest));
            Console.WriteLine("DataFinder status: {0}", results.GetStatus(dataFinderCheckoutRequest));

            // Attempt checkout
            CheckoutResults checkoutResults = client.Checkout(new CheckoutRequest[] { testStandCheckoutRequest, dataFinderCheckoutRequest }, DemoStartMode.DoNotBeginDemo);
            Console.WriteLine("Post checkout - ");
            Console.WriteLine("AllSuccessful: {0}", results.AllSuccessful);
            Console.WriteLine("TestStand status: {0}", results.GetStatus(testStandCheckoutRequest));
            Console.WriteLine("DataFinder status: {0}", results.GetStatus(dataFinderCheckoutRequest));
        }
    }
}

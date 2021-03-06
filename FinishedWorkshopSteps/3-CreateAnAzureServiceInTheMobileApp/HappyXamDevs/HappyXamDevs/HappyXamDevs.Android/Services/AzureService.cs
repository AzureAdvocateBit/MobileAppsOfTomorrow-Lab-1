﻿using System.Threading.Tasks;
using HappyXamDevs.Services;
using Microsoft.WindowsAzure.MobileServices;
using Plugin.CurrentActivity;

[assembly: Xamarin.Forms.Dependency(typeof(HappyXamDevs.Droid.Services.AzureService))]
namespace HappyXamDevs.Droid.Services
{
    public class AzureService : AzureServiceBase
    {
        protected override Task AuthenticateUser()
        {
            return Client.LoginAsync(CrossCurrentActivity.Current.Activity,
                                    MobileServiceAuthenticationProvider.Facebook,
                                    "happyxamdevs");
        }
    }
}
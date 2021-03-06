using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    //newlememk için static yaptık
    public static class Messages
    {
        public static string CarAdded = "Car Added ";
        public static string CustomerAdded = "Customer added";
        public static string RentalAdded = "Rental added";
        public static string UserAdded = "Userr added";
        public static string BrandrAdded = "Brand added";
        public static string ColorAdded = "Color added";

        public static string CarUpdated = "Car Updated ";
        public static string CustomerUpdated = "Customer Updated";
        public static string RentalUpdated = "Rental Updated";
        public static string UserUpdated = "Userr Updated";
        public static string BrandrUpdated = "Brand Updated";
        public static string ColorUpdated = "Color Updated";

        public static string CarDeleted = "Car Deleted ";
        public static string CustomerDeleted = "Customer Deleted";
        public static string RentalDeleted = "Rental Deleted";
        public static string UserDeleted = "Userr Deleted";
        public static string BrandrDeleted = "Brand Deleted";
        public static string ColorDeleted = "Color Deleted";

        public static string CarNameInvalid = "Car name invailid";
        public static string CustomerInvalid = "Customer name invailid";
        public static string RentalInvalid = "Rental name invailid";
        public static string UserInvalid = "User name invailid";
        public static string ColorInvalid = "Color name invailid";
        public static string BrandInvalid = "Brand name invailid";

        public static string MaintinanceTime = "System is under maintenance";

        public static string CarListed = "Cars listed";
        public static string CustomerListed = "Customers listed";
        public static string RentalListed = "Rentals listed";
        public static string UserListed = "Users listed";
        public static string ColorListed = "Color listed";
        public static string BrandListed = "Brand listed";
        public static string RentalAddedError = "Rental Added Error ";
        public static string CarImagesListed = "Car Images Listed";
        public static string CarImageDeleted = "Car Image Deleted";
        public static string FailAddedImageLimit = "FailAddedImageLimit";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kayıtlı ";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Hatalı şifre";
        public static string SuccessfulLogin = "Başarılı giriş";
        internal static string UserAlreadyExists = "Kullanıcı zaten tanımlı ";
        internal static string AccessTokenCreated = "Token oluşturuldu";
    }
}

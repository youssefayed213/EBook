using System.Collections.Generic;
using Ebook.Extensions;
using Ebook.Models.DAL;
using Ebook.Models.Entity.Theme;
using Ebook.Models.Entity.User;
using NToastNotify;

namespace Ebook.Models.BLL
{
    public static class BllTheme
    {
        public static IEnumerable<Theme> GetAllThemes()
        {
            return DalTheme.GetAllThemes();
        }
        
        private static Theme GetThemeBy(string field, string value)
        {
            return DalTheme.GetThemeBy(field, value);
        }
        
        private static JsonResponse NewTheme(Theme u)
        {
            return DalTheme.NewTheme(u);
        }
        
        private static JsonResponse DeleteThemeBy(string field, string value)
        {
            return DalTheme.DeleteThemeBy(field, value);
        }

        private static JsonResponse UpdateTheme(Theme theme)
        {
            return DalTheme.UpdateTheme(theme);
        }
        
        private static JsonResponse UpdateThemeByField(string fieldname, string value, string id)
        {
            return DalTheme.UpdateThemeByField(fieldname, value, id);
        }

        
        public static IEnumerable<Editor> GetAllEditorByTheme(string id)
        {
            return DalTheme.GetAllEditorByTheme(id);
        }
        
        
        #region Theme api
        
        public static JsonResponse DeleteApi(int? id, IToastNotification notification)
        {
            var message = new JsonResponse();
            var themeFromDb = GetThemeBy("Id", id.ToString());
            if (themeFromDb == null)
            {
                message.Success = false;
                message.Message = "Error while Deleting";
            }
            else
            {
                message = DeleteThemeBy("Id", themeFromDb.Id.ToString());
                if (message.Success)
                {
                    message.Message = "Delete successful";
                    notification.AddSuccessToastMessage(message.Message);
                }
                else
                {
                    notification.AddErrorToastMessage(message.Message);
                }
            }

            return message;
        }




        public static JsonResponse UpdateApi(Theme theme, IToastNotification notification)
        {
            var message = UpdateTheme(theme);

            if (message.Success)
            {
                message.Message = "Update successful";
                notification.AddSuccessToastMessage(message.Message);
            }
            else
            {
                message.Success = false;
                notification.AddErrorToastMessage(message.Message);
            }

            return message;
        }

        public static JsonResponse NewThemeApi(Theme theme, IToastNotification notification)
        {
            var message = NewTheme(theme);

            if (message.Success)
            {
                message.Message = "Created successfully";
                notification.AddSuccessToastMessage(message.Message);
            }
            else
            {
                notification.AddErrorToastMessage(message.Message);
            }

            return message;
        }
        
        public static JsonResponse UpdateFieldApi(string fieldname, string value, string id)
        {
            if (string.IsNullOrEmpty(value)) return null;
            var message = UpdateThemeByField(fieldname, value, id);
            message.Extra = value;
            return message;
        }


        #endregion


    }
}
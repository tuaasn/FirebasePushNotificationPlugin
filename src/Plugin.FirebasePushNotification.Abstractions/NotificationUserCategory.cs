﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.FirebasePushNotification.Abstractions
{
    public class NotificationUserCategory
    {
        public string Category { get; }
        public List<NotificationUserAction> Actions { get; }

        public NotificationCategoryType Type { get; }

        public NotificationUserCategory(string category, List<NotificationUserAction> actions, NotificationCategoryType type = NotificationCategoryType.Default)
        {
            Category = category;
            Actions = actions;
            Type = type;
        }
    }

    public class NotificationUserAction
    {
        public string Id { get; }
        public string Title { get; }
        public NotificationActionType Type { get; }
        public NotificationUserAction(string id, string title, NotificationActionType type = NotificationActionType.Default)
        {
            Id = id;
            Title = title;
            Type = type;
        }
    }
}

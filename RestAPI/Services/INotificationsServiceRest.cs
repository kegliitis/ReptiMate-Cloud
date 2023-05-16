﻿using Microsoft.AspNetCore.Mvc;
using Model;

namespace ReptiMate_Cloud.Services;

public interface INotificationsService
{
    Task UpdateNotificationAsync(string id);
    Task<ICollection<Notification>> GetAllNotificationsAsync();
}
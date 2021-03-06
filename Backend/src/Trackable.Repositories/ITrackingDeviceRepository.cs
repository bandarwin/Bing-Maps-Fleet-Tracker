﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Trackable.EntityFramework;
using Trackable.Models;

namespace Trackable.Repositories
{
    /// <summary>
    /// Responsible for handling the tracking device repository.
    /// </summary>
    public interface ITrackingDeviceRepository :
        IRepository<string, TrackingDevice>,
        IDbCountableRepository<string, TrackingDeviceData, TrackingDevice>,
        IDbNamedRepository<string, TrackingDeviceData, TrackingDevice>,
        IDbTaggedRepository<string, TrackingDeviceData, TrackingDevice>
    {
        Task<TrackingDevice> GetDeviceByNameAsync(string name);

        Task<IDictionary<string, TrackingPoint>> GetDevicesLatestPositions();
    }
}
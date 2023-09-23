// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2023, Jiaqi Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Core.Command.SceCommands
{
    [SceCommand(155, "相机设置Yaw角度")]
    public class CameraSetYawCommand : ICommand
    {
        public CameraSetYawCommand(float yaw)
        {
            Yaw = yaw;
        }

        public float Yaw { get; }
    }
}
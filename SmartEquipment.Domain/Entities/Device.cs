using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEquipment.Domain.Entities
{
    public class Device
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        // 狀態
        public bool IsRunning { get; set; }

        // 溫度
        public double Temperature { get; set; }

        // 最後更新時間
        public DateTime LastUpdated { get; set; }
    }
}

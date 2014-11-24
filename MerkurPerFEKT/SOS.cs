using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
namespace MerkurPerFEKT
{
    class SOS
    {
        SerialPort Serial;
        byte[] Motor;
        object WriteLocker = new object();
        public SOS(string Com, int BaudRate)
        {
            Serial = new SerialPort(Com , BaudRate);
        }

        public bool MotorMove(byte Motor, byte Position)
        {
            byte[] Packet = new byte[3];
            Packet[0] = 0xFF;
            Packet[1] = Motor;
            Packet[2] = Position;
            Serial.Write(Packet, 0, 3);
            return true;
        }
        public byte this[int index]
        {
            set
            {
                byte[] Packet = new byte[3];
                Packet[0] = 0xFF;
                Packet[1] = Convert.ToByte(index);
                Packet[2] = value;
                lock(WriteLocker)
                    Serial.Write(Packet, 0, 3);
   
            }
        }

    }
}

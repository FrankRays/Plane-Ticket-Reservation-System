﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    class Trips 
    {
        protected AirCraft craft;
        protected SeatInfo[] seatlist = new SeatInfo[4];
        protected int numOfSeat;
        protected double tripFee; 
      
        public Trips(){ }
        public Trips(AirCraft cra, int n) 
        {
            setCraft(cra);
            setSeats( n);
        }

        public void setCraft(AirCraft craft)
        { this.craft = craft; }
        public AirCraft getCraft()
        { return this.craft; }

        public void setSeats(int numOfSeat)
        { this.numOfSeat = numOfSeat; }
        public int getSeats()
        { return this.numOfSeat; }




        public void addSeatList(SeatInfo seat)
        {
            for (int i = 0; i < 4; i++){
                if (seatlist[i] == null){
                    seatlist[i] = seat;
                    break;
                }
            }
        }

        public double getTotalCharge()
        {
            double tripFee = craft.getPrices();
            int count = 0;

            for (int i = 0; i < 4; i++){
                if (seatlist[i] != null)
                    count++;
            } 

            tripFee *= count;

            return tripFee;
        }
    }
}

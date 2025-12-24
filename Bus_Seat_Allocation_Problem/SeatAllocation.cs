/*
Bus Seat Allocation Problem 

Check if the seat is available or not. 

Book the seat to the user. 

If the booking is cancelled, the next bus is allocated to it

Write the Unit test the code for checking 
    - Seat is allocated or not 
    - Seat is cancelled or not
 */

using System;

namespace Bus_Seat_Allocation_Problem
{
    public class SeatAllocation
    {
        private int seat;

        public int Seat
        {
            get { return seat; }
        }

        public SeatAllocation(int seat)
        {
            if (seat == 0)
            {
                throw new ArgumentException("No seat has been booked");
            }
            seat++;
        }

        public void Book(bool book)
        {
            if (seat == 0)
            {
                throw new ArgumentException("The seat has not been booked");
            }
        }

        public void Check(bool check)
        {
            if (check == false)
            {
                throw new ArgumentException("The booking is cancelled. Change the bus");
            }
        }

    }
}
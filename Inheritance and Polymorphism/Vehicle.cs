﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism
{
    class Vehicle
    {
        //fields
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;
        protected double distanceTraveled;

        private float gearRatio;
        private float engineSize;

        //properties
        public int Seats
        {
            get { return this.seats; }
        }
        public int CarryingCapacity
        {
            get { return this.carryingCapacity; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }

        }

        //constructors
        public Vehicle()
        {

        }
        public Vehicle(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            this.distanceTraveled = 0.9d;
        }

        //methods
        public virtual void Move()
        {
            distanceTraveled += movementSpeed;
        }

        public virtual string GetDistanceTraveled()
        {
            return "Distance traveled: " + distanceTraveled + "\n";
        }


        
    }
}

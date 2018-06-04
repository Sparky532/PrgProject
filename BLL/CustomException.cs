using System;

namespace BLL
{
    [Serializable]
    public class AnimalCriteriaNotMeetException : Exception
    {
        public AnimalCriteriaNotMeetException() { }
        public AnimalCriteriaNotMeetException(string message) : base(message) { }
        public AnimalCriteriaNotMeetException(string message, Exception inner) : base(message, inner) { }
        protected AnimalCriteriaNotMeetException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class NegativeAnimalsException : Exception
    {
        public NegativeAnimalsException() { }
        public NegativeAnimalsException(string message = "Cannot have a negative amount of animals") : base(message) { }
        public NegativeAnimalsException(string message, Exception inner) : base(message, inner) { }
        protected NegativeAnimalsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }


    [Serializable]
    public class FarmerOutOfBoundException : Exception
    {
        public FarmerOutOfBoundException() { }
        public FarmerOutOfBoundException(string message) : base(message) { }
        public FarmerOutOfBoundException(string message, Exception inner) : base(message, inner) { }
        protected FarmerOutOfBoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class NoFarmerNameException : Exception
    {
        public NoFarmerNameException() { }
        public NoFarmerNameException(string message) : base(message) { }
        public NoFarmerNameException(string message, Exception inner) : base(message, inner) { }
        protected NoFarmerNameException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }



    [Serializable]
    public class NoImageDirectoryException : Exception
    {
        public NoImageDirectoryException() { }
        public NoImageDirectoryException(string message) : base(message) { }
        public NoImageDirectoryException(string message, Exception inner) : base(message, inner) { }
        protected NoImageDirectoryException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }


    [Serializable]
    public class CageAmountExceededException : Exception
    {
        public CageAmountExceededException() { }
        public CageAmountExceededException(string message) : base(message) { }
        public CageAmountExceededException(string message, Exception inner) : base(message, inner) { }
        protected CageAmountExceededException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

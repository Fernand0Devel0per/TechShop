﻿using System.Runtime.Serialization;

namespace TechShop.Helpers.Exceptions
{
    [Serializable]
    public class InvalidStatusTransitionException : Exception
    {
     
        public InvalidStatusTransitionException(string message)
            : base(message)
        {
        }

        protected InvalidStatusTransitionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            base.GetObjectData(info, context);
        }
    }
}

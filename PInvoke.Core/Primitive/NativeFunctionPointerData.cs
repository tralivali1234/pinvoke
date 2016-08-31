﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PInvoke.Primitive
{
    public struct NativeFunctionPointerData
    {
        public NativeSymbolId ContainingTypeId {get;}
        public NativeCallingConvention CallingConvention { get; }
        public NativeSimpleId SignatureId { get; }

        public NativeFunctionPointerData(NativeSymbolId containingTypeId, NativeCallingConvention convention, NativeSimpleId signatureId)
        {
            ContainingTypeId = containingTypeId;
            CallingConvention = convention;
            SignatureId = signatureId;
        }
    }
}

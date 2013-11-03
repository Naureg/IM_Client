namespace Network{
    public static class Network{
        /*
         * Message headers are prepended to the outgoing bytes
         * in order for the server/client to determine the contents
         * or purpose of the incoming data
         */
        public struct MessageHeaders{
            public const byte MESSAGE = 0x0;
            public const byte SET_ALIAS = 0x1;
            public const byte REQUEST_PEERS = 0x2;
            public const byte RECEIVED_PEERS = 0x3;
            public const byte RECEIVED_PEER = 0x4;
            public const byte TIMESTAMP = 0x5;
            public const byte DISCONNECT = 0x6;
        }
    }
}

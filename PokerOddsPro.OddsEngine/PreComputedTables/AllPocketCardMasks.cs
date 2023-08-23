﻿namespace PokerOddsPro.OddsEngine.PreComputedTables
{
    public static class AllPocketCardMasks
    {
        /// <summary>
        /// 1326 ulong cards masks for all hold cards.
        /// </summary>
        public static readonly ulong[] TwoCardTable = {
            0xc000000000000, 0xa000000000000, 0x9000000000000, 0x8800000000000, 0x8400000000000,
            0x8200000000000, 0x8100000000000, 0x8080000000000, 0x8040000000000, 0x8020000000000,
            0x8010000000000, 0x8008000000000, 0x8004000000000, 0x8002000000000, 0x8001000000000,
            0x8000800000000, 0x8000400000000, 0x8000200000000, 0x8000100000000, 0x8000080000000,
            0x8000040000000, 0x8000020000000, 0x8000010000000, 0x8000008000000, 0x8000004000000,
            0x8000002000000, 0x8000001000000, 0x8000000800000, 0x8000000400000, 0x8000000200000,
            0x8000000100000, 0x8000000080000, 0x8000000040000, 0x8000000020000, 0x8000000010000,
            0x8000000008000, 0x8000000004000, 0x8000000002000, 0x8000000001000, 0x8000000000800,
            0x8000000000400, 0x8000000000200, 0x8000000000100, 0x8000000000080, 0x8000000000040,
            0x8000000000020, 0x8000000000010, 0x8000000000008, 0x8000000000004, 0x8000000000002,
            0x8000000000001, 0x6000000000000, 0x5000000000000, 0x4800000000000, 0x4400000000000,
            0x4200000000000, 0x4100000000000, 0x4080000000000, 0x4040000000000, 0x4020000000000,
            0x4010000000000, 0x4008000000000, 0x4004000000000, 0x4002000000000, 0x4001000000000,
            0x4000800000000, 0x4000400000000, 0x4000200000000, 0x4000100000000, 0x4000080000000,
            0x4000040000000, 0x4000020000000, 0x4000010000000, 0x4000008000000, 0x4000004000000,
            0x4000002000000, 0x4000001000000, 0x4000000800000, 0x4000000400000, 0x4000000200000,
            0x4000000100000, 0x4000000080000, 0x4000000040000, 0x4000000020000, 0x4000000010000,
            0x4000000008000, 0x4000000004000, 0x4000000002000, 0x4000000001000, 0x4000000000800,
            0x4000000000400, 0x4000000000200, 0x4000000000100, 0x4000000000080, 0x4000000000040,
            0x4000000000020, 0x4000000000010, 0x4000000000008, 0x4000000000004, 0x4000000000002,
            0x4000000000001, 0x3000000000000, 0x2800000000000, 0x2400000000000, 0x2200000000000,
            0x2100000000000, 0x2080000000000, 0x2040000000000, 0x2020000000000, 0x2010000000000,
            0x2008000000000, 0x2004000000000, 0x2002000000000, 0x2001000000000, 0x2000800000000,
            0x2000400000000, 0x2000200000000, 0x2000100000000, 0x2000080000000, 0x2000040000000,
            0x2000020000000, 0x2000010000000, 0x2000008000000, 0x2000004000000, 0x2000002000000,
            0x2000001000000, 0x2000000800000, 0x2000000400000, 0x2000000200000, 0x2000000100000,
            0x2000000080000, 0x2000000040000, 0x2000000020000, 0x2000000010000, 0x2000000008000,
            0x2000000004000, 0x2000000002000, 0x2000000001000, 0x2000000000800, 0x2000000000400,
            0x2000000000200, 0x2000000000100, 0x2000000000080, 0x2000000000040, 0x2000000000020,
            0x2000000000010, 0x2000000000008, 0x2000000000004, 0x2000000000002, 0x2000000000001,
            0x1800000000000, 0x1400000000000, 0x1200000000000, 0x1100000000000, 0x1080000000000,
            0x1040000000000, 0x1020000000000, 0x1010000000000, 0x1008000000000, 0x1004000000000,
            0x1002000000000, 0x1001000000000, 0x1000800000000, 0x1000400000000, 0x1000200000000,
            0x1000100000000, 0x1000080000000, 0x1000040000000, 0x1000020000000, 0x1000010000000,
            0x1000008000000, 0x1000004000000, 0x1000002000000, 0x1000001000000, 0x1000000800000,
            0x1000000400000, 0x1000000200000, 0x1000000100000, 0x1000000080000, 0x1000000040000,
            0x1000000020000, 0x1000000010000, 0x1000000008000, 0x1000000004000, 0x1000000002000,
            0x1000000001000, 0x1000000000800, 0x1000000000400, 0x1000000000200, 0x1000000000100,
            0x1000000000080, 0x1000000000040, 0x1000000000020, 0x1000000000010, 0x1000000000008,
            0x1000000000004, 0x1000000000002, 0x1000000000001, 0xc00000000000, 0xa00000000000,
            0x900000000000, 0x880000000000, 0x840000000000, 0x820000000000, 0x810000000000,
            0x808000000000, 0x804000000000, 0x802000000000, 0x801000000000, 0x800800000000,
            0x800400000000, 0x800200000000, 0x800100000000, 0x800080000000, 0x800040000000,
            0x800020000000, 0x800010000000, 0x800008000000, 0x800004000000, 0x800002000000,
            0x800001000000, 0x800000800000, 0x800000400000, 0x800000200000, 0x800000100000,
            0x800000080000, 0x800000040000, 0x800000020000, 0x800000010000, 0x800000008000,
            0x800000004000, 0x800000002000, 0x800000001000, 0x800000000800, 0x800000000400,
            0x800000000200, 0x800000000100, 0x800000000080, 0x800000000040, 0x800000000020,
            0x800000000010, 0x800000000008, 0x800000000004, 0x800000000002, 0x800000000001,
            0x600000000000, 0x500000000000, 0x480000000000, 0x440000000000, 0x420000000000,
            0x410000000000, 0x408000000000, 0x404000000000, 0x402000000000, 0x401000000000,
            0x400800000000, 0x400400000000, 0x400200000000, 0x400100000000, 0x400080000000,
            0x400040000000, 0x400020000000, 0x400010000000, 0x400008000000, 0x400004000000,
            0x400002000000, 0x400001000000, 0x400000800000, 0x400000400000, 0x400000200000,
            0x400000100000, 0x400000080000, 0x400000040000, 0x400000020000, 0x400000010000,
            0x400000008000, 0x400000004000, 0x400000002000, 0x400000001000, 0x400000000800,
            0x400000000400, 0x400000000200, 0x400000000100, 0x400000000080, 0x400000000040,
            0x400000000020, 0x400000000010, 0x400000000008, 0x400000000004, 0x400000000002,
            0x400000000001, 0x300000000000, 0x280000000000, 0x240000000000, 0x220000000000,
            0x210000000000, 0x208000000000, 0x204000000000, 0x202000000000, 0x201000000000,
            0x200800000000, 0x200400000000, 0x200200000000, 0x200100000000, 0x200080000000,
            0x200040000000, 0x200020000000, 0x200010000000, 0x200008000000, 0x200004000000,
            0x200002000000, 0x200001000000, 0x200000800000, 0x200000400000, 0x200000200000,
            0x200000100000, 0x200000080000, 0x200000040000, 0x200000020000, 0x200000010000,
            0x200000008000, 0x200000004000, 0x200000002000, 0x200000001000, 0x200000000800,
            0x200000000400, 0x200000000200, 0x200000000100, 0x200000000080, 0x200000000040,
            0x200000000020, 0x200000000010, 0x200000000008, 0x200000000004, 0x200000000002,
            0x200000000001, 0x180000000000, 0x140000000000, 0x120000000000, 0x110000000000,
            0x108000000000, 0x104000000000, 0x102000000000, 0x101000000000, 0x100800000000,
            0x100400000000, 0x100200000000, 0x100100000000, 0x100080000000, 0x100040000000,
            0x100020000000, 0x100010000000, 0x100008000000, 0x100004000000, 0x100002000000,
            0x100001000000, 0x100000800000, 0x100000400000, 0x100000200000, 0x100000100000,
            0x100000080000, 0x100000040000, 0x100000020000, 0x100000010000, 0x100000008000,
            0x100000004000, 0x100000002000, 0x100000001000, 0x100000000800, 0x100000000400,
            0x100000000200, 0x100000000100, 0x100000000080, 0x100000000040, 0x100000000020,
            0x100000000010, 0x100000000008, 0x100000000004, 0x100000000002, 0x100000000001,
            0xc0000000000, 0xa0000000000, 0x90000000000, 0x88000000000, 0x84000000000,
            0x82000000000, 0x81000000000, 0x80800000000, 0x80400000000, 0x80200000000,
            0x80100000000, 0x80080000000, 0x80040000000, 0x80020000000, 0x80010000000,
            0x80008000000, 0x80004000000, 0x80002000000, 0x80001000000, 0x80000800000,
            0x80000400000, 0x80000200000, 0x80000100000, 0x80000080000, 0x80000040000,
            0x80000020000, 0x80000010000, 0x80000008000, 0x80000004000, 0x80000002000,
            0x80000001000, 0x80000000800, 0x80000000400, 0x80000000200, 0x80000000100,
            0x80000000080, 0x80000000040, 0x80000000020, 0x80000000010, 0x80000000008,
            0x80000000004, 0x80000000002, 0x80000000001, 0x60000000000, 0x50000000000,
            0x48000000000, 0x44000000000, 0x42000000000, 0x41000000000, 0x40800000000,
            0x40400000000, 0x40200000000, 0x40100000000, 0x40080000000, 0x40040000000,
            0x40020000000, 0x40010000000, 0x40008000000, 0x40004000000, 0x40002000000,
            0x40001000000, 0x40000800000, 0x40000400000, 0x40000200000, 0x40000100000,
            0x40000080000, 0x40000040000, 0x40000020000, 0x40000010000, 0x40000008000,
            0x40000004000, 0x40000002000, 0x40000001000, 0x40000000800, 0x40000000400,
            0x40000000200, 0x40000000100, 0x40000000080, 0x40000000040, 0x40000000020,
            0x40000000010, 0x40000000008, 0x40000000004, 0x40000000002, 0x40000000001,
            0x30000000000, 0x28000000000, 0x24000000000, 0x22000000000, 0x21000000000,
            0x20800000000, 0x20400000000, 0x20200000000, 0x20100000000, 0x20080000000,
            0x20040000000, 0x20020000000, 0x20010000000, 0x20008000000, 0x20004000000,
            0x20002000000, 0x20001000000, 0x20000800000, 0x20000400000, 0x20000200000,
            0x20000100000, 0x20000080000, 0x20000040000, 0x20000020000, 0x20000010000,
            0x20000008000, 0x20000004000, 0x20000002000, 0x20000001000, 0x20000000800,
            0x20000000400, 0x20000000200, 0x20000000100, 0x20000000080, 0x20000000040,
            0x20000000020, 0x20000000010, 0x20000000008, 0x20000000004, 0x20000000002,
            0x20000000001, 0x18000000000, 0x14000000000, 0x12000000000, 0x11000000000,
            0x10800000000, 0x10400000000, 0x10200000000, 0x10100000000, 0x10080000000,
            0x10040000000, 0x10020000000, 0x10010000000, 0x10008000000, 0x10004000000,
            0x10002000000, 0x10001000000, 0x10000800000, 0x10000400000, 0x10000200000,
            0x10000100000, 0x10000080000, 0x10000040000, 0x10000020000, 0x10000010000,
            0x10000008000, 0x10000004000, 0x10000002000, 0x10000001000, 0x10000000800,
            0x10000000400, 0x10000000200, 0x10000000100, 0x10000000080, 0x10000000040,
            0x10000000020, 0x10000000010, 0x10000000008, 0x10000000004, 0x10000000002,
            0x10000000001, 0xc000000000, 0xa000000000, 0x9000000000, 0x8800000000,
            0x8400000000, 0x8200000000, 0x8100000000, 0x8080000000, 0x8040000000,
            0x8020000000, 0x8010000000, 0x8008000000, 0x8004000000, 0x8002000000,
            0x8001000000, 0x8000800000, 0x8000400000, 0x8000200000, 0x8000100000,
            0x8000080000, 0x8000040000, 0x8000020000, 0x8000010000, 0x8000008000,
            0x8000004000, 0x8000002000, 0x8000001000, 0x8000000800, 0x8000000400,
            0x8000000200, 0x8000000100, 0x8000000080, 0x8000000040, 0x8000000020,
            0x8000000010, 0x8000000008, 0x8000000004, 0x8000000002, 0x8000000001,
            0x6000000000, 0x5000000000, 0x4800000000, 0x4400000000, 0x4200000000,
            0x4100000000, 0x4080000000, 0x4040000000, 0x4020000000, 0x4010000000,
            0x4008000000, 0x4004000000, 0x4002000000, 0x4001000000, 0x4000800000,
            0x4000400000, 0x4000200000, 0x4000100000, 0x4000080000, 0x4000040000,
            0x4000020000, 0x4000010000, 0x4000008000, 0x4000004000, 0x4000002000,
            0x4000001000, 0x4000000800, 0x4000000400, 0x4000000200, 0x4000000100,
            0x4000000080, 0x4000000040, 0x4000000020, 0x4000000010, 0x4000000008,
            0x4000000004, 0x4000000002, 0x4000000001, 0x3000000000, 0x2800000000,
            0x2400000000, 0x2200000000, 0x2100000000, 0x2080000000, 0x2040000000,
            0x2020000000, 0x2010000000, 0x2008000000, 0x2004000000, 0x2002000000,
            0x2001000000, 0x2000800000, 0x2000400000, 0x2000200000, 0x2000100000,
            0x2000080000, 0x2000040000, 0x2000020000, 0x2000010000, 0x2000008000,
            0x2000004000, 0x2000002000, 0x2000001000, 0x2000000800, 0x2000000400,
            0x2000000200, 0x2000000100, 0x2000000080, 0x2000000040, 0x2000000020,
            0x2000000010, 0x2000000008, 0x2000000004, 0x2000000002, 0x2000000001,
            0x1800000000, 0x1400000000, 0x1200000000, 0x1100000000, 0x1080000000,
            0x1040000000, 0x1020000000, 0x1010000000, 0x1008000000, 0x1004000000,
            0x1002000000, 0x1001000000, 0x1000800000, 0x1000400000, 0x1000200000,
            0x1000100000, 0x1000080000, 0x1000040000, 0x1000020000, 0x1000010000,
            0x1000008000, 0x1000004000, 0x1000002000, 0x1000001000, 0x1000000800,
            0x1000000400, 0x1000000200, 0x1000000100, 0x1000000080, 0x1000000040,
            0x1000000020, 0x1000000010, 0x1000000008, 0x1000000004, 0x1000000002,
            0x1000000001, 0xc00000000, 0xa00000000, 0x900000000, 0x880000000,
            0x840000000, 0x820000000, 0x810000000, 0x808000000, 0x804000000,
            0x802000000, 0x801000000, 0x800800000, 0x800400000, 0x800200000,
            0x800100000, 0x800080000, 0x800040000, 0x800020000, 0x800010000,
            0x800008000, 0x800004000, 0x800002000, 0x800001000, 0x800000800,
            0x800000400, 0x800000200, 0x800000100, 0x800000080, 0x800000040,
            0x800000020, 0x800000010, 0x800000008, 0x800000004, 0x800000002,
            0x800000001, 0x600000000, 0x500000000, 0x480000000, 0x440000000,
            0x420000000, 0x410000000, 0x408000000, 0x404000000, 0x402000000,
            0x401000000, 0x400800000, 0x400400000, 0x400200000, 0x400100000,
            0x400080000, 0x400040000, 0x400020000, 0x400010000, 0x400008000,
            0x400004000, 0x400002000, 0x400001000, 0x400000800, 0x400000400,
            0x400000200, 0x400000100, 0x400000080, 0x400000040, 0x400000020,
            0x400000010, 0x400000008, 0x400000004, 0x400000002, 0x400000001,
            0x300000000, 0x280000000, 0x240000000, 0x220000000, 0x210000000,
            0x208000000, 0x204000000, 0x202000000, 0x201000000, 0x200800000,
            0x200400000, 0x200200000, 0x200100000, 0x200080000, 0x200040000,
            0x200020000, 0x200010000, 0x200008000, 0x200004000, 0x200002000,
            0x200001000, 0x200000800, 0x200000400, 0x200000200, 0x200000100,
            0x200000080, 0x200000040, 0x200000020, 0x200000010, 0x200000008,
            0x200000004, 0x200000002, 0x200000001, 0x180000000, 0x140000000,
            0x120000000, 0x110000000, 0x108000000, 0x104000000, 0x102000000,
            0x101000000, 0x100800000, 0x100400000, 0x100200000, 0x100100000,
            0x100080000, 0x100040000, 0x100020000, 0x100010000, 0x100008000,
            0x100004000, 0x100002000, 0x100001000, 0x100000800, 0x100000400,
            0x100000200, 0x100000100, 0x100000080, 0x100000040, 0x100000020,
            0x100000010, 0x100000008, 0x100000004, 0x100000002, 0x100000001,
            0xc0000000, 0xa0000000, 0x90000000, 0x88000000, 0x84000000,
            0x82000000, 0x81000000, 0x80800000, 0x80400000, 0x80200000,
            0x80100000, 0x80080000, 0x80040000, 0x80020000, 0x80010000,
            0x80008000, 0x80004000, 0x80002000, 0x80001000, 0x80000800,
            0x80000400, 0x80000200, 0x80000100, 0x80000080, 0x80000040,
            0x80000020, 0x80000010, 0x80000008, 0x80000004, 0x80000002,
            0x80000001, 0x60000000, 0x50000000, 0x48000000, 0x44000000,
            0x42000000, 0x41000000, 0x40800000, 0x40400000, 0x40200000,
            0x40100000, 0x40080000, 0x40040000, 0x40020000, 0x40010000,
            0x40008000, 0x40004000, 0x40002000, 0x40001000, 0x40000800,
            0x40000400, 0x40000200, 0x40000100, 0x40000080, 0x40000040,
            0x40000020, 0x40000010, 0x40000008, 0x40000004, 0x40000002,
            0x40000001, 0x30000000, 0x28000000, 0x24000000, 0x22000000,
            0x21000000, 0x20800000, 0x20400000, 0x20200000, 0x20100000,
            0x20080000, 0x20040000, 0x20020000, 0x20010000, 0x20008000,
            0x20004000, 0x20002000, 0x20001000, 0x20000800, 0x20000400,
            0x20000200, 0x20000100, 0x20000080, 0x20000040, 0x20000020,
            0x20000010, 0x20000008, 0x20000004, 0x20000002, 0x20000001,
            0x18000000, 0x14000000, 0x12000000, 0x11000000, 0x10800000,
            0x10400000, 0x10200000, 0x10100000, 0x10080000, 0x10040000,
            0x10020000, 0x10010000, 0x10008000, 0x10004000, 0x10002000,
            0x10001000, 0x10000800, 0x10000400, 0x10000200, 0x10000100,
            0x10000080, 0x10000040, 0x10000020, 0x10000010, 0x10000008,
            0x10000004, 0x10000002, 0x10000001, 0xc000000, 0xa000000,
            0x9000000, 0x8800000, 0x8400000, 0x8200000, 0x8100000,
            0x8080000, 0x8040000, 0x8020000, 0x8010000, 0x8008000,
            0x8004000, 0x8002000, 0x8001000, 0x8000800, 0x8000400,
            0x8000200, 0x8000100, 0x8000080, 0x8000040, 0x8000020,
            0x8000010, 0x8000008, 0x8000004, 0x8000002, 0x8000001,
            0x6000000, 0x5000000, 0x4800000, 0x4400000, 0x4200000,
            0x4100000, 0x4080000, 0x4040000, 0x4020000, 0x4010000,
            0x4008000, 0x4004000, 0x4002000, 0x4001000, 0x4000800,
            0x4000400, 0x4000200, 0x4000100, 0x4000080, 0x4000040,
            0x4000020, 0x4000010, 0x4000008, 0x4000004, 0x4000002,
            0x4000001, 0x3000000, 0x2800000, 0x2400000, 0x2200000,
            0x2100000, 0x2080000, 0x2040000, 0x2020000, 0x2010000,
            0x2008000, 0x2004000, 0x2002000, 0x2001000, 0x2000800,
            0x2000400, 0x2000200, 0x2000100, 0x2000080, 0x2000040,
            0x2000020, 0x2000010, 0x2000008, 0x2000004, 0x2000002,
            0x2000001, 0x1800000, 0x1400000, 0x1200000, 0x1100000,
            0x1080000, 0x1040000, 0x1020000, 0x1010000, 0x1008000,
            0x1004000, 0x1002000, 0x1001000, 0x1000800, 0x1000400,
            0x1000200, 0x1000100, 0x1000080, 0x1000040, 0x1000020,
            0x1000010, 0x1000008, 0x1000004, 0x1000002, 0x1000001,
            0xc00000, 0xa00000, 0x900000, 0x880000, 0x840000,
            0x820000, 0x810000, 0x808000, 0x804000, 0x802000,
            0x801000, 0x800800, 0x800400, 0x800200, 0x800100,
            0x800080, 0x800040, 0x800020, 0x800010, 0x800008,
            0x800004, 0x800002, 0x800001, 0x600000, 0x500000,
            0x480000, 0x440000, 0x420000, 0x410000, 0x408000,
            0x404000, 0x402000, 0x401000, 0x400800, 0x400400,
            0x400200, 0x400100, 0x400080, 0x400040, 0x400020,
            0x400010, 0x400008, 0x400004, 0x400002, 0x400001,
            0x300000, 0x280000, 0x240000, 0x220000, 0x210000,
            0x208000, 0x204000, 0x202000, 0x201000, 0x200800,
            0x200400, 0x200200, 0x200100, 0x200080, 0x200040,
            0x200020, 0x200010, 0x200008, 0x200004, 0x200002,
            0x200001, 0x180000, 0x140000, 0x120000, 0x110000,
            0x108000, 0x104000, 0x102000, 0x101000, 0x100800,
            0x100400, 0x100200, 0x100100, 0x100080, 0x100040,
            0x100020, 0x100010, 0x100008, 0x100004, 0x100002,
            0x100001, 0xc0000, 0xa0000, 0x90000, 0x88000,
            0x84000, 0x82000, 0x81000, 0x80800, 0x80400,
            0x80200, 0x80100, 0x80080, 0x80040, 0x80020,
            0x80010, 0x80008, 0x80004, 0x80002, 0x80001,
            0x60000, 0x50000, 0x48000, 0x44000, 0x42000,
            0x41000, 0x40800, 0x40400, 0x40200, 0x40100,
            0x40080, 0x40040, 0x40020, 0x40010, 0x40008,
            0x40004, 0x40002, 0x40001, 0x30000, 0x28000,
            0x24000, 0x22000, 0x21000, 0x20800, 0x20400,
            0x20200, 0x20100, 0x20080, 0x20040, 0x20020,
            0x20010, 0x20008, 0x20004, 0x20002, 0x20001,
            0x18000, 0x14000, 0x12000, 0x11000, 0x10800,
            0x10400, 0x10200, 0x10100, 0x10080, 0x10040,
            0x10020, 0x10010, 0x10008, 0x10004, 0x10002,
            0x10001, 0xc000, 0xa000, 0x9000, 0x8800,
            0x8400, 0x8200, 0x8100, 0x8080, 0x8040,
            0x8020, 0x8010, 0x8008, 0x8004, 0x8002,
            0x8001, 0x6000, 0x5000, 0x4800, 0x4400,
            0x4200, 0x4100, 0x4080, 0x4040, 0x4020,
            0x4010, 0x4008, 0x4004, 0x4002, 0x4001,
            0x3000, 0x2800, 0x2400, 0x2200, 0x2100,
            0x2080, 0x2040, 0x2020, 0x2010, 0x2008,
            0x2004, 0x2002, 0x2001, 0x1800, 0x1400,
            0x1200, 0x1100, 0x1080, 0x1040, 0x1020,
            0x1010, 0x1008, 0x1004, 0x1002, 0x1001,
            0xc00, 0xa00, 0x900, 0x880, 0x840,
            0x820, 0x810, 0x808, 0x804, 0x802,
            0x801, 0x600, 0x500, 0x480, 0x440,
            0x420, 0x410, 0x408, 0x404, 0x402,
            0x401, 0x300, 0x280, 0x240, 0x220,
            0x210, 0x208, 0x204, 0x202, 0x201,
            0x180, 0x140, 0x120, 0x110, 0x108,
            0x104, 0x102, 0x101, 0xc0, 0xa0,
            0x90, 0x88, 0x84, 0x82, 0x81,
            0x60, 0x50, 0x48, 0x44, 0x42,
            0x41, 0x30, 0x28, 0x24, 0x22,
            0x21, 0x18, 0x14, 0x12, 0x11,
            0xc, 0xa, 0x9, 0x6, 0x5,
            0x3
        };
    }
}

// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace fbs
{

using global::System;
using global::FlatBuffers;

public struct RspChat : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public const ulong HashID = 0xA3C3784A8BA2A226;
  public static RspChat GetRootAsRspChat(ByteBuffer _bb) { return GetRootAsRspChat(_bb, new RspChat()); }
  public static RspChat GetRootAsRspChat(ByteBuffer _bb, RspChat obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public RspChat __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Say { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSayBytes() { return __p.__vector_as_span(4); }
#else
  public ArraySegment<byte>? GetSayBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetSayArray() { return __p.__vector_as_array<byte>(4); }

  public static Offset<RspChat> CreateRspChat(FlatBufferBuilder builder,
      StringOffset sayOffset = default(StringOffset)) {
    builder.StartObject(1);
    RspChat.AddSay(builder, sayOffset);
    return RspChat.EndRspChat(builder);
  }

  public static void StartRspChat(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddSay(FlatBufferBuilder builder, StringOffset sayOffset) { builder.AddOffset(0, sayOffset.Value, 0); }
  public static Offset<RspChat> EndRspChat(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<RspChat>(o);
  }
};


}

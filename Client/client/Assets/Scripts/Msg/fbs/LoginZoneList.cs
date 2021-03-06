// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace fbs
{

using global::System;
using global::FlatBuffers;

public struct LoginZoneList : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public const ulong HashID = 0x9B7B303F0247713A;
  public static LoginZoneList GetRootAsLoginZoneList(ByteBuffer _bb) { return GetRootAsLoginZoneList(_bb, new LoginZoneList()); }
  public static LoginZoneList GetRootAsLoginZoneList(ByteBuffer _bb, LoginZoneList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public LoginZoneList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ushort Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span(6); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public string Ip { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIpBytes() { return __p.__vector_as_span(8); }
#else
  public ArraySegment<byte>? GetIpBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetIpArray() { return __p.__vector_as_array<byte>(8); }
  public string Port { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPortBytes() { return __p.__vector_as_span(10); }
#else
  public ArraySegment<byte>? GetPortBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetPortArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<LoginZoneList> CreateLoginZoneList(FlatBufferBuilder builder,
      ushort id = 0,
      StringOffset nameOffset = default(StringOffset),
      StringOffset ipOffset = default(StringOffset),
      StringOffset portOffset = default(StringOffset)) {
    builder.StartObject(4);
    LoginZoneList.AddPort(builder, portOffset);
    LoginZoneList.AddIp(builder, ipOffset);
    LoginZoneList.AddName(builder, nameOffset);
    LoginZoneList.AddId(builder, id);
    return LoginZoneList.EndLoginZoneList(builder);
  }

  public static void StartLoginZoneList(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, ushort id) { builder.AddUshort(0, id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddIp(FlatBufferBuilder builder, StringOffset ipOffset) { builder.AddOffset(2, ipOffset.Value, 0); }
  public static void AddPort(FlatBufferBuilder builder, StringOffset portOffset) { builder.AddOffset(3, portOffset.Value, 0); }
  public static Offset<LoginZoneList> EndLoginZoneList(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<LoginZoneList>(o);
  }
};


}

-- automatically generated by the FlatBuffers compiler, do not modify

-- namespace: fbs

local flatbuffers = require('3rd.flatbuffers')

---@class RspLoginSelectZone
local RspLoginSelectZone = {} -- the module

local RspLoginSelectZone_mt = {} -- the class metatable

RspLoginSelectZone.HashID = 0x569DFA3DC8ECEB19;

function RspLoginSelectZone.New()
    local o = {}
    setmetatable(o, {__index = RspLoginSelectZone_mt})
    return o
end

function RspLoginSelectZone.GetRootAsRspLoginSelectZone(buf, offset)
    local n = flatbuffers.N.UOffsetT:Unpack(buf, offset)
    local o = RspLoginSelectZone.New()
    o:Init(buf, n + offset)
    return o
end

function RspLoginSelectZone.init(buf, offset)
    return RspLoginSelectZone.GetRootAsRspLoginSelectZone(buf, offset)
end

function RspLoginSelectZone_mt:
Init(buf, pos)
    self.view = flatbuffers.view.New(buf, pos)
end

function RspLoginSelectZone_mt:Ok()
    local o = self.view:Offset(4)
    if o ~= 0 then
        return (self.view:Get(flatbuffers.N.Bool, o + self.view.pos) ~= 0)
    end
    return false
end

function RspLoginSelectZone.Start(builder) builder:StartObject(1) end
function RspLoginSelectZone.AddOk(builder, ok) builder:PrependBoolSlot(0, ok, 0) end
function RspLoginSelectZone.End(builder) return builder:EndObject() end

return RspLoginSelectZone -- return the module
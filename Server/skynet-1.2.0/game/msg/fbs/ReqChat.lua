-- automatically generated by the FlatBuffers compiler, do not modify

-- namespace: fbs

local flatbuffers = require('flatbuffers')

---@class ReqChat
local ReqChat = {} -- the module

local ReqChat_mt = {} -- the class metatable

ReqChat.HashID = 0x9291D76D5CC9BF89;

function ReqChat.New()
    local o = {}
    setmetatable(o, {__index = ReqChat_mt})
    return o
end

function ReqChat.GetRootAsReqChat(buf, offset)
    local n = flatbuffers.N.UOffsetT:Unpack(buf, offset)
    local o = ReqChat.New()
    o:Init(buf, n + offset)
    return o
end

function ReqChat.init(buf, offset)
    ReqChat.GetRootAsReqChat(buf, offset)
end

function ReqChat_mt:
Init(buf, pos)
    self.view = flatbuffers.view.New(buf, pos)
end

function ReqChat_mt:Say()
    local o = self.view:Offset(4)
    if o ~= 0 then
        return self.view:String(o + self.view.pos)
    end
end

function ReqChat.Start(builder) builder:StartObject(1) end
function ReqChat.AddSay(builder, say) builder:PrependUOffsetTRelativeSlot(0, say, 0) end
function ReqChat.End(builder) return builder:EndObject() end

return ReqChat -- return the module
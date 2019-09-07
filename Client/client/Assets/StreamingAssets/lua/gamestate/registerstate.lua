---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/9/1 12:20
---

local basestate = require("gamestate.basestate")

---@class registerstate
local registerstate = luaclass(basestate)

function registerstate:onEnter()
    print("registerstate.onEnter")

    basestate:onEnter(self)
end

function registerstate:onExit()
    print("registerstate.onExit")

    basestate:onExit(self)
end

function registerstate:onRefresh()
    print("registerstate.onRefresh")

    basestate:onRefresh(self)
end

return registerstate:new()
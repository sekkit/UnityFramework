---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/9/1 12:19
---


local event = require("base.eventlib")

---@class basestate
local basestate = luaclass();

function basestate:onEnter()
    print("baseclass.onEnter")

end

function basestate:onExit()
    print("baseclass.onExit")

end

function basestate:onRefresh()
    print("basestate.onRefresh")

end

return basestate;
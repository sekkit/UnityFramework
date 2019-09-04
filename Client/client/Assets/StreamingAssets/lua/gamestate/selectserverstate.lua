---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/9/1 12:19
---

--local baseclass = require("base.luaclass")
local basestate = require("gamestate.basestate")
local event = require("base.eventlib")

---@class selectserverstate
selectserverstate = luaclass(basestate);

selectserverstate.evententer = event:new()
selectserverstate.eventrefresh= event:new()
selectserverstate.eventexit = event:new()

function selectserverstate.onEnter()
    print("selectserverstate.onEnter")

    selectserverstate.evententer:Fire()
end

function selectserverstate.onExit()
    print("selectserverstate.onExit")

    selectserverstate.eventexit:Fire()
end

function selectserverstate.onRefresh()
    print("selectserverstate.onRefresh")

    selectserverstate.eventrefresh:Fire()
end

return selectserverstate:new()
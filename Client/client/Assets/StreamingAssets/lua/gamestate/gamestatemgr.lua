---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/9/1 12:21
---

require("base.luaclass")

local loginstate = require("gamestate.loginstate")
local registerstate = require("gamestate.registerstate")
local gamestate = require("gamestate.gamestate")
local selectserverstate = require("gamestate.selectserverstate")

---@class gamestatemgr
gamestatemgr = {}

gamestatemgr.statedict = {}

gamestatemgr.curstate = nil

function gamestatemgr.register()

    gamestatemgr.statedict[global.gamestatetype.login] = loginstate
    gamestatemgr.statedict[global.gamestatetype.register] = registerstate
    gamestatemgr.statedict[global.gamestatetype.game] = gamestate
    gamestatemgr.statedict[global.gamestatetype.selectserver] = selectserverstate

    print("gamestatemgr.register " .. #gamestatemgr.statedict)
end

function gamestatemgr.unregister()
    gamestatemgr.statedict = {}
    gamestatemgr.curstate = nil
end

function gamestatemgr.changeState(statetype)

    if gamestatemgr.curstate then
        local prestate = gamestatemgr.statedict[gamestatemgr.curstate]
        if prestate then
            prestate:onExit()
        end
    end

    gamestatemgr.curstate = statetype;

    if gamestatemgr.curstate then
        local curstate = gamestatemgr.statedict[gamestatemgr.curstate]
        if curstate then
            curstate:onEnter()
        end
    end
end

return gamestatemgr
---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/9/1 6:33
---

---@type msgdispatcher
local msgdispatcher = require("msgdispatcher.msgdispatcher")

local reqloginacc = require("msg.fbs.ReqLoginAccount")

local rsploginacc = require("msg.fbs.RspLoginAccount")

local reqregacc = require("msg.fbs.ReqRegisterAccount")

local rspregacc = require("msg.fbs.RspRegisterAccount")

---@type event
local event = require("base.event")

---@class loginmodel
loginmodel = {}

---------------------------------------继承函数---------------------------------------

function loginmodel.create()
    msgdispatcher.registerFbMsg(rsploginacc, loginmodel.onRspLoginAcc_sc)
    msgdispatcher.registerFbMsg(rspregacc, loginmodel.onRspRegAcc_sc)

    loginmodel.onRegAccEvent = event:new()
end

function loginmodel.close()
    msgdispatcher.unRegisterFbMsg(rsploginacc, loginmodel.onRspLoginAcc_sc)
    msgdispatcher.unRegisterFbMsg(rspregacc, loginmodel.onRspRegAcc_sc)

    loginmodel.onRegAccEvent:Clear()
end

--------------------------------------------------------------------------------------











---------------------------------------消息事件---------------------------------------

function loginmodel.sendreqregacc_cs(_account, _password)
    ---@type builder
    local builder = msgdispatcher.newBuilder(1024)

    local account = builder:CreateString(_account)
    local password = builder:CreateString(_password)

    reqregacc.Start(builder)
    reqregacc.AddAccount(builder, account)
    reqregacc.AddPassword(builder, password)

    local orc = reqregacc.End(builder)
    builder:Finish(orc)

    msgdispatcher.sendFbMsg(reqregacc, builder)
end

function loginmodel.sendreqloginacc_cs(_account, _password)

    ---@type builder
    local builder = msgdispatcher.newBuilder(1024)

    local account = builder:CreateString(_account)
    local password = builder:CreateString(_password)

    reqloginacc.Start(builder)
    reqloginacc.AddAccount(builder, account)
    reqloginacc.AddPassword(builder, password)

    local orc = reqloginacc.End(builder)
    builder:Finish(orc)

    msgdispatcher.sendFbMsg(reqloginacc, builder)
end

function loginmodel.onRspLoginAcc_sc(msg)
    local strok = ""
    if msg.Ok then
        strok = "true"
    else
        strok = "false"
    end

    print("onRspLoginAcc_sc " .. strok)


end

function loginmodel.onRspRegAcc_sc(msg)
    local strok = ""
    if msg.Ok then
        strok = "true"
    else
        strok = "false"
    end

    print("onRspRegAcc_sc " .. strok)

    if msg.Ok then
        loginmodel.onRegAccEvent(loginmodel.onRegAccEvent)
    end
end

--------------------------------------------------------------------------------------









-------------------------------------外部调用-------------------------------------------

local loginstate = require("gamestate.loginstate")
loginstate.evententer:AddHandler(function()
    print("loginstate.evententer")

    global.INetManager:SendConnect("192.168.0.108", 5000)

    local ui_login = require("ui.ui_login.ui_login")
    ui_login.show()
end)

--------------------------------------------------------------------------------------


return loginmodel;

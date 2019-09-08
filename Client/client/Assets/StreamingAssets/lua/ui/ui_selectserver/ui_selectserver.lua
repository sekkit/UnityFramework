---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/9/1 6:21
---

---@class ui_selectserver
ui_selectserver = {}

ui_selectserver.uiname = "ui_panel_selectserver"

---@type testmodel
ui_selectserver.model = loginmodel


----------------------------------------------内置-------------------------------------------------

function ui_selectserver.show()

    if ui_selectserver.isShow then
        return
    end

    ---@type gtmGame.Dialog
    ui_selectserver.dialog = ui_mgr.createDialog(ui_selectserver.uiname, "ui_selectserver")

    if not ui_selectserver.dialog then
        print("ui_selectserver.dialog null uiname " .. ui_selectserver.uiname)
    end

    ui_selectserver.isShow = true;

    ui_selectserver.initui()
    ui_selectserver.initEvent()
    ui_selectserver.initData()
    ui_selectserver.initState()
end

function ui_selectserver.close()
    ui_mgr.closeDialog(ui_selectserver.uiname);
end

function ui_selectserver.preShow()
    print("ui_selectserver.preShow")
end

function ui_selectserver.preHide()
    print("ui_selectserver.preHide")
end

function ui_selectserver.preClose()
    print("ui_selectserver.preClose")

    ui_selectserver.isShow = false;
    ui_selectserver.uiref = {};

    ui_selectserver.removeEvent()
    ui_selectserver.clearData()
end

--- initui
function ui_selectserver.initui()
    ui_selectserver.uiref = {};

    local root = ui_selectserver.dialog.rootDialog
    ui_selectserver.uiref.btn_server = ui_selectserver.dialog:GetButtonInChild(root, "btn_server")
    ui_selectserver.uiref.lbl_server_name = ui_selectserver.dialog:GetTextInChild(ui_selectserver.uiref.btn_server.gameObject, "Text")

    ui_selectserver.uiref.btn_confirm = ui_selectserver.dialog:GetButtonInChild(root, "btn_confirm")
    ui_selectserver.uiref.group_selserver = ui_selectserver.dialog:GetGameObjectInChild(root, "group_selserver")

    ui_selectserver.uiref.btn_close = ui_selectserver.dialog:GetButtonInChild(ui_selectserver.uiref.group_selserver, "btn_close")
    ui_selectserver.uiref.scroll_serverlist = ui_selectserver.dialog:GetButtonInChild(ui_selectserver.uiref.group_selserver, "scroll_serverlist")
end

--- init event
function ui_selectserver.initEvent()
    ui_selectserver.dialog:AddBtnClickListener(ui_selectserver.uiref.btn_confirm, ui_selectserver.onConfirmBtnClick)
    ui_selectserver.dialog:AddBtnClickListener(ui_selectserver.uiref.btn_server, ui_selectserver.onServerBtnClick)
    ui_selectserver.dialog:AddBtnClickListener(ui_selectserver.uiref.btn_close, ui_selectserver.onCloseBtnClick)
end

--- remove event
function ui_selectserver.removeEvent()

end

function ui_selectserver.initData()
    ui_selectserver.initSelZoneId()
end

function ui_selectserver.clearData()
    ui_selectserver.selzoneid = nil
end

function ui_selectserver.initState()
    ui_selectserver.refreshUI()
end

--------------------------------------------------------------------------------------------------












-------------------------------------------ui事件-------------------------------------------------

function ui_selectserver.onConfirmBtnClick()
    local zonedata = logindata.getZoneData(ui_selectserver.selzoneid)
    if not zonedata then
        return
    end

end

function ui_selectserver.onServerBtnClick()
    ui_selectserver.dialog:SetGameObjectVisible(ui_selectserver.uiref.group_selserver, true)
end

function ui_selectserver.onCloseBtnClick()
    ui_selectserver.dialog:SetGameObjectVisible(ui_selectserver.uiref.group_selserver, false)
end

--------------------------------------------------------------------------------------------------












---------------------------------------------外部事件----------------------------------------------



--------------------------------------------------------------------------------------------------











-----------------------------------------------函数------------------------------------------------

function ui_selectserver.initSelZoneId()
    ui_selectserver.selzoneid = nil

    local zonecnt = logindata.getZoneListCnt()
    if zonecnt <= 0 then
        return
    end

    ui_selectserver.selzoneid = 1
end

function ui_selectserver.refreshUI()
    local zonedata = logindata.getZoneData(ui_selectserver.selzoneid)
    if not zonedata then
        return
    end

    ui_selectserver.dialog:SetText(ui_selectserver.uiref.lbl_server_name, zonedata.name)

    global.INetManager:SendConnect(zonedata.ip, zonedata.port)
end

--------------------------------------------------------------------------------------------------



return ui_selectserver;
---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/9/1 6:21
---

---@class ui_selectserver
ui_selectserver = {}

ui_selectserver.uiname = "ui_selectserver"

---@type testmodel
ui_selectserver.model = nil


----------------------------------------------内置-------------------------------------------------

function ui_selectserver.show()

    if ui_selectserver.isShow then
        return
    end

    ---@type gtmGame.Dialog
    ui_selectserver.dialog = ui_mgr.createDialog(ui_selectserver.uiname, "ui_selectserver");

    if not ui_selectserver.dialog then
        print("ui_selectserver.dialog null uiname " .. ui_selectserver.uiname);
    end

    ui_selectserver.isShow = true;

    ui_selectserver.initui();
    ui_selectserver.initEvent();
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
end

--- initui
function ui_selectserver.initui()
    ui_selectserver.uiref = {};


end

--- init event
function ui_selectserver.initEvent()

end

--------------------------------------------------------------------------------------------------












-------------------------------------------ui事件-------------------------------------------------



--------------------------------------------------------------------------------------------------
















return ui_selectserver;
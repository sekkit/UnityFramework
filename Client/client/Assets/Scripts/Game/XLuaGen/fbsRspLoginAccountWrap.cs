﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class fbsRspLoginAccountWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(fbs.RspLoginAccount);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "__init", _m___init);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "__assign", _m___assign);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ByteBuffer", _g_get_ByteBuffer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Ok", _g_get_Ok);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 7, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRootAsRspLoginAccount", _m_GetRootAsRspLoginAccount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateRspLoginAccount", _m_CreateRspLoginAccount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "StartRspLoginAccount", _m_StartRspLoginAccount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddOk", _m_AddOk_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndRspLoginAccount", _m_EndRspLoginAccount_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HashID", fbs.RspLoginAccount.HashID);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (LuaAPI.lua_gettop(L) == 1)
				{
				    translator.Push(L, default(fbs.RspLoginAccount));
			        return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to fbs.RspLoginAccount constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRootAsRspLoginAccount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<FlatBuffers.ByteBuffer>(L, 1)) 
                {
                    FlatBuffers.ByteBuffer __bb = (FlatBuffers.ByteBuffer)translator.GetObject(L, 1, typeof(FlatBuffers.ByteBuffer));
                    
                        fbs.RspLoginAccount gen_ret = fbs.RspLoginAccount.GetRootAsRspLoginAccount( __bb );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<FlatBuffers.ByteBuffer>(L, 1)&& translator.Assignable<fbs.RspLoginAccount>(L, 2)) 
                {
                    FlatBuffers.ByteBuffer __bb = (FlatBuffers.ByteBuffer)translator.GetObject(L, 1, typeof(FlatBuffers.ByteBuffer));
                    fbs.RspLoginAccount _obj;translator.Get(L, 2, out _obj);
                    
                        fbs.RspLoginAccount gen_ret = fbs.RspLoginAccount.GetRootAsRspLoginAccount( __bb, _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to fbs.RspLoginAccount.GetRootAsRspLoginAccount!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m___init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                fbs.RspLoginAccount gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    int __i = LuaAPI.xlua_tointeger(L, 2);
                    FlatBuffers.ByteBuffer __bb = (FlatBuffers.ByteBuffer)translator.GetObject(L, 3, typeof(FlatBuffers.ByteBuffer));
                    
                    gen_to_be_invoked.__init( __i, __bb );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m___assign(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                fbs.RspLoginAccount gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    int __i = LuaAPI.xlua_tointeger(L, 2);
                    FlatBuffers.ByteBuffer __bb = (FlatBuffers.ByteBuffer)translator.GetObject(L, 3, typeof(FlatBuffers.ByteBuffer));
                    
                        fbs.RspLoginAccount gen_ret = gen_to_be_invoked.__assign( __i, __bb );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateRspLoginAccount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<FlatBuffers.FlatBufferBuilder>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    byte _ok = (byte)LuaAPI.xlua_tointeger(L, 2);
                    
                        FlatBuffers.Offset<fbs.RspLoginAccount> gen_ret = fbs.RspLoginAccount.CreateRspLoginAccount( _builder, _ok );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<FlatBuffers.FlatBufferBuilder>(L, 1)) 
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    
                        FlatBuffers.Offset<fbs.RspLoginAccount> gen_ret = fbs.RspLoginAccount.CreateRspLoginAccount( _builder );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to fbs.RspLoginAccount.CreateRspLoginAccount!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartRspLoginAccount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    
                    fbs.RspLoginAccount.StartRspLoginAccount( _builder );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddOk_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    byte _ok = (byte)LuaAPI.xlua_tointeger(L, 2);
                    
                    fbs.RspLoginAccount.AddOk( _builder, _ok );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndRspLoginAccount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    
                        FlatBuffers.Offset<fbs.RspLoginAccount> gen_ret = fbs.RspLoginAccount.EndRspLoginAccount( _builder );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ByteBuffer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                fbs.RspLoginAccount gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                translator.Push(L, gen_to_be_invoked.ByteBuffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Ok(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                fbs.RspLoginAccount gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Ok);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}

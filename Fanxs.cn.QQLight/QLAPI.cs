using System;
using System.Runtime.InteropServices;

namespace Fanxs.cn.QQLight
{
    class QLAPI
    {
        static int hModule = 0;
        /// <summary>
        /// 先行初始化
        /// </summary>
        public static void init()
        {
            hModule = Method.LoadLibrary(@"message.dll");
        }

        /// 给QQ名片点赞
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
        // [DllImport("message.dll", EntryPoint = "Api_SendPraise", CallingConvention = CallingConvention.Winapi)]
        public static void Api_SendPraise(string QQID, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SendPraise");
                LapiDelegate.Api_SendPraise run = (LapiDelegate.Api_SendPraise)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SendPraise));
                run(QQID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }


        /// <summary>
        /// 抖动QQ好友
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
        // [DllImport("message.dll")]
        public static void Api_SendShake(string QQID, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SendShake");
                LapiDelegate.Api_SendShake run = (LapiDelegate.Api_SendShake)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SendShake));
                run(QQID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }

        }

        /// <summary>
        /// 取得网页操作时需要的bkn/gtk
        /// </summary>
        /// <param name="Cookies"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_Getbkn", CallingConvention = CallingConvention.Winapi)]
        public static String Api_Getbkn(string Cookies, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_Getbkn");
                LapiDelegate.Api_Getbkn run = (LapiDelegate.Api_Getbkn)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_Getbkn));
                res = run(Cookies, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {

                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }

        /// <summary>
        /// 取得网页操作时需要的bkn/gtk
        /// </summary>
        /// <param name="Cookies"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_Getbkn_Long", CallingConvention = CallingConvention.Winapi)]
        public static String Api_Getbkn_Long(string Cookies, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_Getbkn_Long");
                LapiDelegate.Api_Getbkn_Long run = (LapiDelegate.Api_Getbkn_Long)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_Getbkn_Long));
                res = run(Cookies, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {

                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }

        /// <summary>
        /// 退出群
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_QuitGroup", CallingConvention = CallingConvention.Winapi)]
        public static void Api_QuitGroup(string GroupID, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_QuitGroup");
                LapiDelegate.Api_QuitGroup run = (LapiDelegate.Api_QuitGroup)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_QuitGroup));
                run(GroupID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 退出讨论组
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_QuitDiscussGroup", CallingConvention = CallingConvention.Winapi)]
        public static void Api_QuitDiscussGroup(string GroupID, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_QuitDiscussGroup");
                LapiDelegate.Api_QuitDiscussGroup run = (LapiDelegate.Api_QuitDiscussGroup)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_QuitDiscussGroup));
                run(GroupID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 修改个性签名
        /// </summary>
        /// <param name="Signature"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetSignature", CallingConvention = CallingConvention.Winapi)]
        public static void Api_SetSignature(string Signature, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SetSignature");
                LapiDelegate.Api_SetSignature run = (LapiDelegate.Api_SetSignature)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SetSignature));
                run(Signature, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 修改讨论组名称
        /// </summary>
        /// <param name="DiscussGroupID"></param>
        /// <param name="Name"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetDiscussName", CallingConvention = CallingConvention.Winapi)]
        public static void Api_SetDiscussName(string DiscussGroupID, string Name, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SetDiscussName");
                LapiDelegate.Api_SetDiscussName run = (LapiDelegate.Api_SetDiscussName)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SetDiscussName));
                run(DiscussGroupID, Name, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 修改群名称
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="Name"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetGroupName", CallingConvention = CallingConvention.Winapi)]
        public static void Api_SetGroupName(string GroupID, string Name, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SetGroupName");
                LapiDelegate.Api_SetGroupName run = (LapiDelegate.Api_SetGroupName)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SetGroupName));
                run(GroupID, Name, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 设置全群禁言
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="IsBanGroup"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_BanGroup", CallingConvention = CallingConvention.Winapi)]
        public static void Api_BanGroup(string GroupID, bool IsBanGroup, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_BanGroup");
                LapiDelegate.Api_BanGroup run = (LapiDelegate.Api_BanGroup)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_BanGroup));
                run(GroupID, IsBanGroup, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 设置管理员权限
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="QQID"></param>
        /// <param name="IsManager"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetManager", CallingConvention = CallingConvention.Winapi)]
        public static void Api_SetManager(string GroupID, string QQID, bool IsManager, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SetManager");
                LapiDelegate.Api_SetManager run = (LapiDelegate.Api_SetManager)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SetManager));
                run(GroupID, QQID, IsManager, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 禁言群成员
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="QQ"></param>
        /// <param name="time"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_Ban", CallingConvention = CallingConvention.Winapi)]
        public static void Api_Ban(string GroupID, string QQ, int time, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_Ban");
                LapiDelegate.Api_Ban run = (LapiDelegate.Api_Ban)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_Ban));
                run(GroupID, QQ, time, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 修改匿名权限
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="IsSetAnony"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetAnony", CallingConvention = CallingConvention.Winapi)]
        public static void Api_SetAnony(string GroupID, bool IsSetAnony, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SetAnony");
                LapiDelegate.Api_SetAnony run = (LapiDelegate.Api_SetAnony)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SetAnony));
                run(GroupID, IsSetAnony, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 踢出群成员
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="QQID"></param>
        /// <param name="IsBan"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_RemoveMember", CallingConvention = CallingConvention.Winapi)]
        public static void Api_RemoveMember(string GroupID, string QQID, bool IsBan, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_RemoveMember");
                LapiDelegate.Api_RemoveMember run = (LapiDelegate.Api_RemoveMember)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_RemoveMember));
                run(GroupID, QQID, IsBan, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 解散群
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_RemoveGroup", CallingConvention = CallingConvention.Winapi)]
        public static void Api_RemoveGroup(string GroupID, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_RemoveGroup");
                LapiDelegate.Api_RemoveGroup run = (LapiDelegate.Api_RemoveGroup)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_RemoveGroup));
                run(GroupID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 取得操作网页用的cookies
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetCookies", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetCookies(int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetCookies");
                LapiDelegate.Api_GetCookies run = (LapiDelegate.Api_GetCookies)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetCookies));
                res = run(AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }

        /// <summary>
        /// 取得QQ空间的Token
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetQzoneToken", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetQzoneToken(int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetQzoneToken");
                LapiDelegate.Api_GetQzoneToken run = (LapiDelegate.Api_GetQzoneToken)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetQzoneToken));
                res = run(AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }

        /// <summary>
        /// 取得QQ空间的Cookies
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetQzoneCookies", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetQzoneCookies(int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetQzoneCookies");
                LapiDelegate.Api_GetQzoneCookies run = (LapiDelegate.Api_GetQzoneCookies)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetQzoneCookies));
                res = run(AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }

        /// <summary>
        /// 发表说说
        /// </summary>
        /// <param name="Str"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_SendTaotao", CallingConvention = CallingConvention.Winapi)]
        public static string Api_SendTaotao(string Str, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("发表失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SendTaotao");
                LapiDelegate.Api_SendTaotao run = (LapiDelegate.Api_SendTaotao)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SendTaotao));
                res = run(Str, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }

        /// <summary>
        /// 取得所登录的QQ
        /// </summary>
        /// <param name="Str"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetLoginQQ", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetLoginQQ(int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetLoginQQ");
                LapiDelegate.Api_GetLoginQQ run = (LapiDelegate.Api_GetLoginQQ)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetLoginQQ));
                res = run(AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }
        /// <summary>
        /// 框架为插件所创建的插件目录
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetPath", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetPath(int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetPath");
                LapiDelegate.Api_GetPath run = (LapiDelegate.Api_GetPath)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetPath));
                res = run(AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }

        /// <summary>
        /// 置插件错误管理
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="Str"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_Error", CallingConvention = CallingConvention.Winapi)]
        public static string Api_SetErrorCode(string Code, string Str, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SetErrorCode");
                LapiDelegate.Api_SetErrorCode run = (LapiDelegate.Api_SetErrorCode)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SetErrorCode));
                res = run(Code, Str, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }

        /// <summary>
        /// 机器人发送消息，返回值为该条消息的ID
        /// </summary>
        /// <param name="type"></param>
        /// <param name="GroupID"></param>
        /// <param name="QQID"></param>
        /// <param name="Msg"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll")]
        public static string Api_SendMsg(int type, string GroupID, string QQID, string Msg, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SendMsg");
                LapiDelegate.Api_SendMsg run = (LapiDelegate.Api_SendMsg)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SendMsg));
                res = run(type, GroupID, QQID, Msg, AuthCode);
                Api_SendLog("测试", Marshal.PtrToStringAnsi(res), 2, AuthCode);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }
        /// <summary>
        /// 处理加群消息
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="QQID"></param>
        /// <param name="Seq"></param>
        /// <param name="type"></param>
        /// <param name="Reason"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_SetGroupAdd", CallingConvention = CallingConvention.Winapi)]
        public static void Api_SetGroupAdd(string GroupID, string QQID, string Seq, int type, string Reason, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SetGroupAdd");
                LapiDelegate.Api_SetGroupAdd run = (LapiDelegate.Api_SetGroupAdd)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SetGroupAdd));
                run(GroupID, QQID, Seq, type, Reason, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }
        /// <summary>
        /// 处理加好友信息
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="type"></param>
        /// <param name="Reason"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_SetFriendAdd", CallingConvention = CallingConvention.Winapi)]
        public static void Api_SetFriendAdd(string QQID, int type, string Reason, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SetFriendAdd");
                LapiDelegate.Api_SetFriendAdd run = (LapiDelegate.Api_SetFriendAdd)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SetFriendAdd));
                run(QQID, type, Reason, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 向框架推送一条日志
        /// </summary>
        /// <param name="type"></param>
        /// <param name="Msg"></param>
        /// <param name="FontColor"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_SendLog", CallingConvention = CallingConvention.Winapi)]
        public static void Api_SendLog(string type, string Msg, int FontColor, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SendLog");
                LapiDelegate.Api_SendLog run = (LapiDelegate.Api_SendLog)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SendLog));
                run(type, Msg, FontColor, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }
        /// <summary>
        /// 修改好友备注
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="Name"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetFriendName", CallingConvention = CallingConvention.Winapi)]
        public static void Api_SetFriendName(string QQID, string Name, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SetFriendName");
                LapiDelegate.Api_SetFriendName run = (LapiDelegate.Api_SetFriendName)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SetFriendName));
                run(QQID, Name, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }
        /// <summary>
        /// 删除好友
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="Name"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_DeleteFriend", CallingConvention = CallingConvention.Winapi)]
        public static void Api_DeleteFriend(string QQID, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_DeleteFriend");
                LapiDelegate.Api_DeleteFriend run = (LapiDelegate.Api_DeleteFriend)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_DeleteFriend));
                run(QQID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }
        /// <summary>
        /// 主动加群
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="Msg"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_AddGroup", CallingConvention = CallingConvention.Winapi)]
        public static void Api_AddGroup(string GroupID, string info, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_AddGroup");
                LapiDelegate.Api_AddGroup run = (LapiDelegate.Api_AddGroup)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_AddGroup));
                run(GroupID, info, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }
        /// <summary>
        /// 主动添加好友
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="info"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_AddFriend", CallingConvention = CallingConvention.Winapi)]
        public static void Api_AddFriend(string QQID, string info, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_AddFriend");
                LapiDelegate.Api_AddFriend run = (LapiDelegate.Api_AddFriend)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_AddFriend));
                run(QQID, info, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }
        /// <summary>
        /// 返回卡片点歌JSON代码
        /// </summary>
        /// <param name="SongID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_JsonMusic", CallingConvention = CallingConvention.Winapi)]
        public static string Api_JsonMusic(string SongID, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_JsonMusic");
                LapiDelegate.Api_JsonMusic run = (LapiDelegate.Api_JsonMusic)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_JsonMusic));
                res = run(SongID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }
        /// <summary>
        /// 取得群内成员的名片
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetGroupCard", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetGroupCard(string GroupID, string QQID, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetGroupCard");
                LapiDelegate.Api_GetGroupCard run = (LapiDelegate.Api_GetGroupCard)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetGroupCard));
                res = run(GroupID, QQID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }
        /// <summary>
        /// 取得指定QQ的昵称
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetNick", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetNick(string QQID, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetNick");
                LapiDelegate.Api_GetNick run = (LapiDelegate.Api_GetNick)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetNick));
                res = run(QQID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }
        /// <summary>
        /// 取得指定群的名称
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetGroupName", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetGroupName(string GroupID, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetGroupName");
                LapiDelegate.Api_GetGroupName run = (LapiDelegate.Api_GetGroupName)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetGroupName));
                res = run(GroupID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }
        /// <summary>
        /// 获取框架版本
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetSoftVersion", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetSoftVersion(int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetSoftVersion");
                LapiDelegate.Api_GetSoftVersion run = (LapiDelegate.Api_GetSoftVersion)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetSoftVersion));
                res = run(AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }
        /// <summary>
        /// 获取群介绍（使用闪退复现，原因正在排查）
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetGroupIntroduce", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetGroupIntroduce(string GroupID, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetGroupIntroduce");
                LapiDelegate.Api_GetGroupIntroduce run = (LapiDelegate.Api_GetGroupIntroduce)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetGroupIntroduce));
                res = run(GroupID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }

        /// <summary>
        /// 获取群主
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetGroupOwner", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetGroupOwner(string GroupID, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetGroupOwner");
                LapiDelegate.Api_GetGroupOwner run = (LapiDelegate.Api_GetGroupOwner)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetGroupOwner));
                res = run(GroupID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }
        /// <summary>
        /// 修改群成员的名片
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="QQID"></param>
        /// <param name="NewCard"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetGroupCard", CallingConvention = CallingConvention.Winapi)]
        public static void Api_SetGroupCard(string GroupID, string QQID, string NewCard, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SetGroupCard");
                LapiDelegate.Api_SetGroupCard run = (LapiDelegate.Api_SetGroupCard)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SetGroupCard));
                run(GroupID, QQID, NewCard, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 取得某个QQ的名片赞数量
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetPraiseNum", CallingConvention = CallingConvention.Winapi)]
        public static int Api_GetPraiseNum(string QQID, int AuthCode)
        {
            int res = 0;
            try
            {
                if (hModule == 0) return res;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetPraiseNum");
                LapiDelegate.Api_GetPraiseNum run = (LapiDelegate.Api_GetPraiseNum)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetPraiseNum));
                res = run(QQID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return res;
        }
        /// <summary>
        /// 取得某个QQ的等级
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetQQLevel", CallingConvention = CallingConvention.Winapi)]
        public static int Api_GetQQLevel(string QQID, int AuthCode)
        {
            int res = 0;
            try
            {
                if (hModule == 0) return res;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetQQLevel");
                LapiDelegate.Api_GetQQLevel run = (LapiDelegate.Api_GetQQLevel)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetQQLevel));
                res = run(QQID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return res;
        }

        /// <summary>
        /// 修改机器人昵称
        /// </summary>
        /// <param name="NewNick"></param>
        /// <param name="AuthCode"></param>
        // [DllImport("message.dll", EntryPoint = "Api_SetNick", CallingConvention = CallingConvention.Winapi)]
        public static void Api_SetNick(string NewNick, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SetNick");
                LapiDelegate.Api_SetNick run = (LapiDelegate.Api_SetNick)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SetNick));
                run(NewNick, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }


        /// <summary>
        /// 获取说说点赞数量
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="URL"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_Taotaodolike", CallingConvention = CallingConvention.Winapi)]
        public static int Api_Taotaodolike(string QQID, string URL, int AuthCode)
        {
            int res = 0;
            try
            {
                if (hModule == 0) return res;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_Taotaodolike");
                LapiDelegate.Api_Taotaodolike run = (LapiDelegate.Api_Taotaodolike)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_Taotaodolike));
                res = run(QQID, URL, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return res;
        }

        /// <summary>
        /// 评论说说并获取数量
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="URL"></param>
        /// <param name="Content"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_Taotaofeeds", CallingConvention = CallingConvention.Winapi)]
        public static int Api_Taotaofeeds(string QQID, string URL, string Content, int AuthCode)
        {
            int res = 0;
            try
            {
                if (hModule == 0) return res;
                IntPtr intPtr = Method.GetProcAddress(hModule, " Api_Taotaofeeds");
                LapiDelegate.Api_Taotaofeeds run = (LapiDelegate.Api_Taotaofeeds)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_Taotaofeeds));
                res = run(QQID, URL, Content, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return res;
        }

        /// <summary>
        /// 获取QQ龄
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetQQAge", CallingConvention = CallingConvention.Winapi)]
        public static int Api_GetQQAge(string QQID, int AuthCode)
        {
            int res = 0;
            try
            {
                if (hModule == 0) return res;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetQQAge");
                LapiDelegate.Api_GetQQAge run = (LapiDelegate.Api_GetQQAge)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetQQAge));
                res = run(QQID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return res;
        }

        /// <summary>
        /// 取QQ性别 1.男
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetQQSex", CallingConvention = CallingConvention.Winapi)]
        public static int Api_GetQQSex(string QQID, int AuthCode)
        {
            int res = 0;
            try
            {
                if (hModule == 0) return res;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetQQSex");
                LapiDelegate.Api_GetQQSex run = (LapiDelegate.Api_GetQQSex)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetQQSex));
                res = run(QQID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return res;
        }

        /// <summary>
        /// 以JSON形式取得好友列表
        /// </summary>
        /// <param name="Cache"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetFriendList", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetFriendList(bool Cache, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetFriendList");
                LapiDelegate.Api_GetFriendList run = (LapiDelegate.Api_GetFriendList)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetFriendList));
                res = run(Cache, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }
        /// <summary>
        /// 以JSON形式取得群列表
        /// </summary>
        /// <param name="Cache"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetGroupList", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetGroupList(bool Cache, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetGroupList");
                LapiDelegate.Api_GetGroupList run = (LapiDelegate.Api_GetGroupList)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetGroupList));
                res = run(Cache, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }
        /// <summary>
        /// 以JSON形式取得群成员列表
        /// </summary>
        /// <param name="Cache"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetGroupMemberList", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetGroupMemberList(string GroupID, bool Cache, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetGroupMemberList");
                LapiDelegate.Api_GetGroupMemberList run = (LapiDelegate.Api_GetGroupMemberList)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetGroupMemberList));
                res = run(GroupID, Cache, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }

        /// <summary>
        /// 以JSON形式取得某QQ个人信息
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetQQInfo", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetQQInfo(string QQID, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetQQInfo");
                LapiDelegate.Api_GetQQInfo run = (LapiDelegate.Api_GetQQInfo)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetQQInfo));
                res = run(QQID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }

        /// <summary>
        /// 以JSON形式取得某群信息
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetGroupInfo", CallingConvention = CallingConvention.Winapi)]
        public static string Api_GetGroupInfo(string GroupID, int AuthCode)
        {
            IntPtr res = Marshal.StringToHGlobalAnsi("获取失败");
            try
            {
                if (hModule == 0) return Marshal.PtrToStringAnsi(res);
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_GetGroupMemberList");
                LapiDelegate.Api_GetGroupInfo run = (LapiDelegate.Api_GetGroupInfo)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_GetGroupInfo));
                res = run(GroupID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
            return Marshal.PtrToStringAnsi(res);
        }

        /// <summary>
        /// 撤回自身消息 发出消息不可以秒撤回，腾讯限制，1~2s后才可撤回
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="GroupID"></param>
        /// <param name="QQID"></param>
        /// <param name="MsgID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_DeleteMsg", CallingConvention = CallingConvention.Winapi)]
        public static void Api_DeleteMsg(string Type, string GroupID, string QQID, string MsgID, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_DeleteMsg");
                LapiDelegate.Api_DeleteMsg run = (LapiDelegate.Api_DeleteMsg)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_DeleteMsg));
                run(Type, GroupID, QQID, MsgID, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 改变QQ在线状态
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "QL_SetQQState", CallingConvention = CallingConvention.Winapi)]
        public static void Api_SetQQState(int Type, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SetQQState");
                LapiDelegate.QL_SetQQState run = (LapiDelegate.QL_SetQQState)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.QL_SetQQState));
                run(Type, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }
        /** 此api有问题
            /// <summary>
            /// 邀请好友入群
            /// </summary>
            /// <param name="GroupID"></param>
            /// <param name="QQID"></param>
            /// <param name="AuthCode"></param>
           // [DllImport("message.dll", EntryPoint = "Api_InviteFriend)", CallingConvention = CallingConvention.Winapi)]
            public static void QL_InviteFriendToGroup(string GroupID, string QQID, int AuthCode)
            {
                try
                {
                    if (hModule == 0) return;
                    IntPtr intPtr = Method.GetProcAddress(hModule, "Api_InviteFriendToGroup");
                    LapiDelegate.QL_SetQQState run = (LapiDelegate.QL_SetQQState)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.QL_SetQQState));
                    run(Type, AuthCode);

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                finally
                {
                    //Method.FreeLibrary(hModule); //卸载一次模块
                }
            }
        **/
        /// <summary>
        /// 上传图片，获得图片GUID
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Obj"></param>
        /// <param name="Bin"></param>
        /// <param name="AuthCode"></param>
        // [DllImport("message.dll", EntryPoint = "Api_UpLoadPic", CallingConvention = CallingConvention.Winapi)]
        public static void Api_UpLoadPic(int Type, string Obj, string Bin, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_UpLoadPic");
                LapiDelegate.Api_UpLoadPic run = (LapiDelegate.Api_UpLoadPic)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_UpLoadPic));
                run(Type, Obj, Bin, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }
        /// <summary>
        /// 设置插件状态，开启或关闭
        /// </summary>
        /// <param name="State"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetPluginState", CallingConvention = CallingConvention.Winapi)]
        public static void Api_SetPluginState(bool State, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_SetPluginState");
                LapiDelegate.Api_SetPluginState run = (LapiDelegate.Api_SetPluginState)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_SetPluginState));
                run(State, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="GroupNUm"></param>
        /// <param name="FileGuid"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_DeleteFile", CallingConvention = CallingConvention.Winapi)]
        public static void Api_DeleteFile(string GroupNUm, string FileGuid, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_DeleteFile");
                LapiDelegate.Api_DeleteFile run = (LapiDelegate.Api_DeleteFile)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_DeleteFile));
                run(GroupNUm, FileGuid, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 转发群文件，可以转发好友文件或者群文件到其他群里(FromUser填写好友QQ或者群号)
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="GroupNum"></param>
        /// <param name="FileGuid"></param>
        /// <param name="AuthCode"></param>
        // [DllImport("message.dll", EntryPoint = "Api_RepeatFile", CallingConvention = CallingConvention.Winapi)]
        public static void Api_RepeatFile(string GroupID, string GroupNum, string FileGuid, int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_RepeatFile");
                LapiDelegate.Api_RepeatFile run = (LapiDelegate.Api_RepeatFile)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_RepeatFile));
                run(GroupID, GroupNum, FileGuid, AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }

        /// <summary>
        /// 一键清空所有离线文件
        /// </summary>
        /// <param name="AuthCode"></param>
        // [DllImport("message.dll", EntryPoint = "Api_ClearOffLineFile", CallingConvention = CallingConvention.Winapi)]
        public static void Api_ClearOffLineFile(int AuthCode)
        {
            try
            {
                if (hModule == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModule, "Api_ClearOffLineFile");
                LapiDelegate.Api_ClearOffLineFile run = (LapiDelegate.Api_ClearOffLineFile)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.Api_ClearOffLineFile));
                run(AuthCode);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModule); //卸载一次模块
            }
        }


        /// <summary>
        /// 初始化com库
        /// </summary>
        /// <param name="pvReserved"></param>
       // [DllImport("ole32.dll", EntryPoint = "CoInitialize", CallingConvention = CallingConvention.Winapi)]
        public static void CoInitialize(int pvReserved)
        {
            int hModuleOle = Method.LoadLibrary(@"ole32.dll");
            try
            {
                if (hModuleOle == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModuleOle, "CoInitialize");
                LapiDelegate.CoInitialize run = (LapiDelegate.CoInitialize)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.CoInitialize));
                run(pvReserved);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModuleOle); //卸载一次模块
            }
        }

        /// <summary>
        /// 取消com库
        /// </summary>
       // [DllImport("ole32.dll", EntryPoint = "CoUninitialize", CallingConvention = CallingConvention.Winapi)]
        public static void CoUninitialize()
        {
            int hModuleOle = Method.LoadLibrary(@"ole32.dll");
            try
            {
                if (hModuleOle == 0) return;
                IntPtr intPtr = Method.GetProcAddress(hModuleOle, "CoInitialize");
                LapiDelegate.CoUninitialize run = (LapiDelegate.CoUninitialize)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(LapiDelegate.CoUninitialize));
                run();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "API报错", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                //Method.FreeLibrary(hModuleOle); //卸载一次模块
            }
        }


    }
}

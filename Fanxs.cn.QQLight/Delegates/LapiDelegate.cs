using System;
using System.Runtime.InteropServices;

namespace Fanxs.cn.QQLight
{
    class LapiDelegate
    {
        /**
         Author：Fanxing
         定义API委托
        **/

        /// 给QQ名片点赞
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
        // [DllImport("message.dll", EntryPoint = "Api_SendPraise", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_SendPraise(string QQID, int AuthCode);

        /// <summary>
        /// 抖动QQ好友
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll")]
        public delegate void Api_SendShake(string QQID, int AuthCode);

        /// <summary>
        /// 取得网页操作时需要的bkn/gtk
        /// </summary>
        /// <param name="Cookies"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_Getbkn", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_Getbkn(string Cookies, int AuthCode);

        /// <summary>
        /// 取得网页操作时需要的bkn/gtk
        /// </summary>
        /// <param name="Cookies"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_Getbkn_Long", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_Getbkn_Long(string Cookies, int AuthCode);

        /// <summary>
        /// 退出群
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_QuitGroup", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_QuitGroup(string GroupID, int AuthCode);

        /// <summary>
        /// 退出讨论组
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_QuitDiscussGroup", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_QuitDiscussGroup(string GroupID, int AuthCode);

        /// <summary>
        /// 修改个性签名
        /// </summary>
        /// <param name="Signature"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetSignature", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_SetSignature(string Signature, int AuthCode);

        /// <summary>
        /// 修改讨论组名称
        /// </summary>
        /// <param name="DiscussGroupID"></param>
        /// <param name="Name"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetDiscussName", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_SetDiscussName(string DiscussGroupID, string Name, int AuthCode);

        /// <summary>
        /// 修改群名称
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="Name"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetGroupName", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_SetGroupName(string GroupID, string Name, int AuthCode);

        /// <summary>
        /// 设置全群禁言
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="IsBanGroup"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_BanGroup", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_BanGroup(string GroupID, bool IsBanGroup, int AuthCode);

        /// <summary>
        /// 设置管理员权限
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="QQID"></param>
        /// <param name="IsManager"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetManager", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_SetManager(string GroupID, string QQID, bool IsManager, int AuthCode);

        /// <summary>
        /// 禁言群成员
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="QQ"></param>
        /// <param name="time"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_Ban", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_Ban(string GroupID, string QQ, int time, int AuthCode);

        /// <summary>
        /// 修改匿名权限
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="IsSetAnony"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetAnony", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_SetAnony(string GroupID, bool IsSetAnony, int AuthCode);

        /// <summary>
        /// 踢出群成员
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="QQID"></param>
        /// <param name="IsBan"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_RemoveMember", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_RemoveMember(string GroupID, string QQID, bool IsBan, int AuthCode);

        /// <summary>
        /// 解散群
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_RemoveGroup", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_RemoveGroup(string GroupID, int AuthCode);

        /// <summary>
        /// 取得操作网页用的cookies
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetCookies", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetCookies(int AuthCode);

        /// <summary>
        /// 取得QQ空间的Token
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetQzoneToken", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetQzoneToken(int AuthCode);

        /// <summary>
        /// 取得QQ空间的Cookies
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetQzoneCookies", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetQzoneCookies(int AuthCode);

        /// <summary>
        /// 发表说说
        /// </summary>
        /// <param name="Str"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_SendTaotao", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_SendTaotao(string Str, int AuthCode);

        /// <summary>
        /// 取得所登录的QQ
        /// </summary>
        /// <param name="Str"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetLoginQQ", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetLoginQQ(int AuthCode);
        /// <summary>
        /// 框架为插件所创建的插件目录
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetPath", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetPath(int AuthCode);

        /// <summary>
        /// 置插件错误管理
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="Str"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_Error", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_SetErrorCode(string Code, string Str, int AuthCode);

        /// <summary>
        /// 机器人发送消息，返回值为该条消息的ID
        /// </summary>
        /// <param name="type"></param>
        /// <param name="GroupID"></param>
        /// <param name="QQID"></param>
        /// <param name="Msg"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr Api_SendMsg(int type, string GroupID, string QQID, string Msg, int AuthCode);
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
        public delegate void Api_SetGroupAdd(string GroupID, string QQID, string Seq, int type, string Reason, int AuthCode);
        /// <summary>
        /// 处理加好友信息
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="type"></param>
        /// <param name="Reason"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_SetFriendAdd", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_SetFriendAdd(string QQID, int type, string Reason, int AuthCode);

        /// <summary>
        /// 向框架推送一条日志
        /// </summary>
        /// <param name="type"></param>
        /// <param name="Msg"></param>
        /// <param name="FontColor"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_SendLog", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_SendLog(string type, string Msg, int FontColor, int AuthCode);
        /// <summary>
        /// 修改好友备注
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="Name"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetFriendName", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_SetFriendName(string QQID, string Name, int AuthCode);
        /// <summary>
        /// 删除好友
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="Name"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_DeleteFriend", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_DeleteFriend(string QQID, int AuthCode);
        /// <summary>
        /// 主动加群
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="Msg"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_AddGroup", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_AddGroup(string GroupID, string info, int AuthCode);
        /// <summary>
        /// 主动添加好友
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="info"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_AddFriend", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_AddFriend(string QQID, string info, int AuthCode);
        /// <summary>
        /// 返回卡片点歌JSON代码
        /// </summary>
        /// <param name="SongID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_JsonMusic", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_JsonMusic(string SongID, int AuthCode);
        /// <summary>
        /// 取得群内成员的名片
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetGroupCard", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetGroupCard(string GroupID, string QQID, int AuthCode);
        /// <summary>
        /// 取得指定QQ的昵称
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetNick", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetNick(string QQID, int AuthCode);
        /// <summary>
        /// 取得指定群的名称
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetGroupName", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetGroupName(string GroupID, int AuthCode);
        /// <summary>
        /// 获取框架版本
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetSoftVersion", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetSoftVersion(int AuthCode);
        /// <summary>
        /// 获取群介绍（使用闪退复现，原因正在排查）
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetGroupIntroduce", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetGroupIntroduce(string GroupID, int AuthCode);

        /// <summary>
        /// 获取群主
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_GetGroupOwner", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetGroupOwner(string GroupID, int AuthCode);
        /// <summary>
        /// 修改群成员的名片
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="QQID"></param>
        /// <param name="NewCard"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetGroupCard", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_SetGroupCard(string GroupID, string QQID, string NewCard, int AuthCode);

        /// <summary>
        /// 取得某个QQ的名片赞数量
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetPraiseNum", CallingConvention = CallingConvention.Winapi)]
        public delegate int Api_GetPraiseNum(string QQID, int AuthCode);
        /// <summary>
        /// 取得某个QQ的等级
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetQQLevel", CallingConvention = CallingConvention.Winapi)]
        public delegate int Api_GetQQLevel(string QQID, int AuthCode);

        // [DllImport("message.dll", EntryPoint = "Api_SetNick", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_SetNick(string NewNick, int AuthCode);


        /// <summary>
        /// 获取说说点赞数量
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="URL"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_Taotaodolike", CallingConvention = CallingConvention.Winapi)]
        public delegate int Api_Taotaodolike(string QQID, string URL, int AuthCode);

        /// <summary>
        /// 获取说说评论数量
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="URL"></param>
        /// <param name="Content"></param>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
       // [DllImport("message.dll", EntryPoint = "Api_Taotaofeeds", CallingConvention = CallingConvention.Winapi)]
        public delegate int Api_Taotaofeeds(string QQID, string URL, string Content, int AuthCode);

        /// <summary>
        /// 获取QQ龄
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetQQAge", CallingConvention = CallingConvention.Winapi)]
        public delegate int Api_GetQQAge(string QQID, int AuthCode);

        /// <summary>
        /// 取QQ性别
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetQQSex", CallingConvention = CallingConvention.Winapi)]
        public delegate int Api_GetQQSex(string QQID, int AuthCode);

        /// <summary>
        /// 以JSON形式取得好友列表
        /// </summary>
        /// <param name="Cache"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetFriendList", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetFriendList(bool Cache, int AuthCode);
        /// <summary>
        /// 以JSON形式取得群列表
        /// </summary>
        /// <param name="Cache"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetGroupList", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetGroupList(bool Cache, int AuthCode);
        /// <summary>
        /// 以JSON形式取得群成员列表
        /// </summary>
        /// <param name="Cache"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetGroupMemberList", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetGroupMemberList(string GroupID, bool Cache, int AuthCode);

        /// <summary>
        /// 以JSON形式取得某QQ个人信息
        /// </summary>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_GetQQInfo", CallingConvention = CallingConvention.Winapi)]
        public delegate IntPtr Api_GetQQInfo(string QQID, int AuthCode);

        /// <summary>
        /// 以JSON形式取得某群信息
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="AuthCode"></param>
        public delegate IntPtr Api_GetGroupInfo(string GroupID, int AuthCode);

        /// <summary>
        /// 撤回自身消息 发出消息不可以秒撤回，腾讯限制，1~2s后才可撤回
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="GroupID"></param>
        /// <param name="QQID"></param>
        /// <param name="MsgID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_DeleteMsg", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_DeleteMsg(string Type, string GroupID, string QQID, string MsgID, int AuthCode);

        /// <summary>
        /// 改变QQ在线状态
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "QL_SetQQState", CallingConvention = CallingConvention.Winapi)]
        public delegate void QL_SetQQState(int Type, int AuthCode);

        /// <summary>
        /// 邀请好友入群
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="QQID"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_InviteFriend)", CallingConvention = CallingConvention.Winapi)]
        public delegate void QL_InviteFriendToGroup(string GroupID, string QQID, int AuthCode);

        /// <summary>
        /// 上传图片，获得图片GUID
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Obj"></param>
        /// <param name="Bin"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_UpLoadPic", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_UpLoadPic(int Type, string Obj, string Bin, int AuthCode);
        /// <summary>
        /// 设置插件状态，开启或关闭
        /// </summary>
        /// <param name="State"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_SetPluginState", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_SetPluginState(bool State, int AuthCode);

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="GroupNUm"></param>
        /// <param name="FileGuid"></param>
        /// <param name="AuthCode"></param>
       // [DllImport("message.dll", EntryPoint = "Api_DeleteFile", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_DeleteFile(string GroupNUm, string FileGuid, int AuthCode);

        // [DllImport("message.dll", EntryPoint = "Api_RepeatFile", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_RepeatFile(string GroupID, string GroupNum, string FileGuid, int AuthCode);

        // [DllImport("message.dll", EntryPoint = "Api_ClearOffLineFile", CallingConvention = CallingConvention.Winapi)]
        public delegate void Api_ClearOffLineFile(int AuthCode);


        /// <summary>
        /// 初始化com库
        /// </summary>
        /// <param name="pvReserved"></param>
       // [DllImport("ole32.dll", EntryPoint = "CoInitialize", CallingConvention = CallingConvention.Winapi)]
        public delegate void CoInitialize(int pvReserved);

        /// <summary>
        /// 取消com库
        /// </summary>
       // [DllImport("ole32.dll", EntryPoint = "CoUninitialize", CallingConvention = CallingConvention.Winapi)]
        public delegate void CoUninitialize();



    }
}

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

namespace SCSKiller.App;

/// <summary>
/// 简体中文专用版的显示层。内部状态和协议仍保持英文，避免改变核心逻辑；这里只翻译
/// 已经进入视觉树的控件文本。后续新增词条集中在这里维护。
/// </summary>
internal static class ChineseLocalization
{
    static readonly Dictionary<string, string> Text = new(StringComparer.Ordinal)
    {
        ["Library"] = "游戏库", ["Compile queue"] = "编译队列", ["Settings"] = "设置", ["About"] = "关于",
        ["Shader Compilation Stutter Killer"] = "着色器编译卡顿终结者",
        ["GPU"] = "显卡", ["Refresh"] = "刷新", ["Add a game…"] = "添加游戏…", ["Add a game"] = "添加游戏",
        ["Add all"] = "全部添加", ["Add all ready"] = "添加所有可编译游戏", ["Add all recommended"] = "添加所有推荐游戏",
        ["Compile"] = "编译", ["Compile queue (0)"] = "编译队列（0）", ["Recommended"] = "推荐",
        ["Search by name, store or engine"] = "按名称、商店或引擎搜索",
        ["Game"] = "游戏", ["Shaders"] = "着色器", ["Pipelines"] = "管线", ["Cache"] = "缓存", ["Time"] = "时间", ["Status"] = "状态",
        ["Recommended to compile"] = "推荐编译", ["known to stutter"] = "已知会卡顿", ["Warmed"] = "已预热",
        ["Ready to compile"] = "可编译", ["Play"] = "启动", ["Details"] = "详细信息", ["Add to queue"] = "加入队列",
        ["Steam"] = "Steam", ["Epic Games"] = "Epic Games", ["Xbox / Game Pass"] = "Xbox / Game Pass",
        ["EA app"] = "EA app", ["Other"] = "其他", ["Compile speed"] = "编译速度", ["threads"] = "线程",
        ["Ask me first"] = "先询问我", ["Below-normal priority"] = "低于正常优先级", ["measured"] = "已测量",
        ["Driver shader cache"] = "驱动着色器缓存", ["After a driver update"] = "驱动更新后", ["Change"] = "更改",
        ["Slow frames"] = "慢帧", ["Shader coverage"] = "着色器覆盖率",
        ["Frame times last time you played"] = "上次游戏的帧时间", ["Record while I play"] = "游戏时录制",
        ["Turn on recording"] = "开启录制", ["Clear recording"] = "清除录制", ["Careful compile"] = "谨慎编译",
        ["Ban risk"] = "封禁风险", ["Running"] = "运行中", ["In queue"] = "队列中",
        ["Queue"] = "队列", ["Pause"] = "暂停", ["Resume"] = "继续",
        ["Cancel"] = "取消", ["Close"] = "关闭", ["OK"] = "确定", ["Save"] = "保存", ["Open"] = "打开",
        ["Check for updates"] = "检查更新", ["Download source code"] = "下载源代码", ["Source code"] = "源代码",
        ["Website"] = "官方网站", ["Trademarks"] = "商标", ["Third-party components"] = "第三方组件",
        ["Support on Patreon"] = "在 Patreon 上支持", ["Restart to update"] = "重启以更新",
        ["First compile"] = "首次编译", ["Last compile"] = "上次编译", ["Compile time"] = "编译时间",
        ["Disk space"] = "磁盘空间", ["None"] = "无", ["Unknown"] = "未知", ["Unlimited"] = "无限制",
        ["Disabled"] = "已禁用", ["Stable"] = "稳定版", ["Beta (Patreon supporter)"] = "测试版（Patreon 支持者）",
        ["Alpha (Patreon backer)"] = "内测版（Patreon 赞助者）", ["About supporting SCSKiller"] = "关于支持 SCSKiller",
        ["Sign in with Patreon"] = "使用 Patreon 登录", ["Continue without"] = "暂不登录",
        ["Driver default limit may evict games"] = "驱动默认上限可能会清理游戏缓存", ["The cache is nearly full"] = "缓存空间即将用尽",
        ["shader compile"] = "着色器编译", ["other hitch"] = "其他卡顿", ["loading"] = "加载中",
        ["loading, compiling shaders"] = "加载、编译着色器", ["quitting"] = "退出中",
        ["Current limit"] = "当前上限", ["Used now"] = "当前已用", ["New limit"] = "新上限",
        ["Apply (needs administrator)"] = "应用（需要管理员权限）",
        ["You can switch back to the driver default here at any time."] = "你可以随时在此切回驱动默认设置。",
        ["A new driver throws away every compiled shader, so compiled games stutter again until they are rebuilt."] = "新驱动会丢弃所有已编译的着色器，因此游戏需要重新构建后才不会再次卡顿。",
        ["When to rebuild"] = "何时重新构建", ["Ask me"] = "询问我", ["Automatically, only while the PC is idle"] = "仅在电脑空闲时自动执行", ["Off"] = "关闭",
        ["A notification offers Compile now, When idle, or Skip. Nothing starts on its own."] = "通知会提供立即编译、空闲时编译或跳过选项，不会自动开始。",
        ["Stops the moment you touch the mouse or keyboard and picks up where it left off."] = "一旦操作鼠标或键盘就会停止，下次从中断处继续。",
        ["Rebuild games yourself from the Library."] = "请在游戏库中手动重新构建游戏。",
        ["Pause background compiling while another game is running"] = "运行其他游戏时暂停后台编译",
        ["Threads for background rebuilds"] = "后台重建线程数", ["Auto Shader Compilation (NVIDIA beta)"] = "自动着色器编译（NVIDIA 测试版）",
        ["System utilization"] = "系统利用率", ["We recommend enabling it"] = "建议启用此功能",
        ["Patreon and community database"] = "Patreon 和社区数据库",
        ["Refresh status"] = "刷新状态", ["Sign out"] = "退出登录", ["Signed in with Patreon"] = "已使用 Patreon 登录",
        ["Share anonymously"] = "匿名分享", ["Not now"] = "暂不分享", ["Update channel"] = "更新频道", ["Go back to stable now"] = "立即切回稳定版",
        ["Download shared shader hashes"] = "下载共享着色器哈希", ["Share anonymous shader hashes"] = "分享匿名着色器哈希",
        ["Compile speed when you run the queue"] = "运行队列时的编译速度", ["Compile threads"] = "编译线程数", ["Maximum memory for compiling"] = "编译最大内存",
        ["In the background"] = "后台运行", ["Start SCSKiller when Windows starts"] = "Windows 启动时运行 SCSKiller",
        ["Closing the window quits SCSKiller"] = "关闭窗口时退出 SCSKiller", ["Scan games when SCSKiller starts"] = "SCSKiller 启动时扫描游戏",
        ["Notify me when games have new shaders to compile"] = "游戏有新的着色器可编译时通知我", ["Send an anonymous daily check"] = "每天发送匿名检查",
        ["Record in all compatible games"] = "在所有兼容的游戏中录制", ["Recording limit per game"] = "每个游戏的录制上限", ["Space by game"] = "按游戏查看空间",
        ["Install updates automatically"] = "自动安装更新",
        ["A downloaded update installs the next time SCSKiller starts or quits, never during a compile, an offline session or a game. Off: only Restart to update installs it."] = "已下载的更新会在 SCSKiller 下次启动或退出时安装，不会在编译、离线会话或游戏运行期间安装。关闭后仅通过“重启以更新”安装。",
        ["Open one to read its licence. The same list, with notes, is in THIRD-PARTY-NOTICES.md next to the app."] = "打开项目即可查看许可证。同样的列表和说明位于程序旁的 THIRD-PARTY-NOTICES.md 文件中。",
        ["Compiles your games' shaders into the graphics driver's cache ahead of time, so they don't stutter the first time you play them."] = "提前将游戏着色器编译到显卡驱动缓存中，避免首次游玩时出现卡顿。",
    };

    public static void Apply(FrameworkElement root)
    {
        Translate(root);
    }

    static void Translate(DependencyObject node)
    {
        if (node is TextBlock tb && HasLocal(tb, TextBlock.TextProperty)) tb.Text = TranslateText(tb.Text);
        if (node is TextBox box && HasLocal(box, TextBox.PlaceholderTextProperty)) box.PlaceholderText = TranslateText(box.PlaceholderText);
        if (node is Button b && HasLocal(b, ContentControl.ContentProperty) && b.Content is string s) b.Content = TranslateText(s);
        if (node is HyperlinkButton hb && HasLocal(hb, ContentControl.ContentProperty) && hb.Content is string hs) hb.Content = TranslateText(hs);
        if (node is NavigationViewItem ni && HasLocal(ni, ContentControl.ContentProperty) && ni.Content is string ns) ni.Content = TranslateText(ns);
        if (node is Expander ex && HasLocal(ex, Expander.HeaderProperty) && ex.Header is string eh) ex.Header = TranslateText(eh);
        if (node is InfoBar ib)
        {
            if (HasLocal(ib, InfoBar.TitleProperty)) ib.Title = TranslateText(ib.Title);
            if (HasLocal(ib, InfoBar.MessageProperty)) ib.Message = TranslateText(ib.Message);
        }
        if (node is TitleBar title)
        {
            if (HasLocal(title, TitleBar.SubtitleProperty)) title.Subtitle = TranslateText(title.Subtitle);
        }
        for (int i = 0; i < VisualTreeHelper.GetChildrenCount(node); i++)
            Translate(VisualTreeHelper.GetChild(node, i));
    }

    static bool HasLocal(DependencyObject node, DependencyProperty property) =>
        node.ReadLocalValue(property) != DependencyProperty.UnsetValue;

    static string TranslateText(string? value)
    {
        if (string.IsNullOrWhiteSpace(value)) return value ?? "";
        if (Text.TryGetValue(value, out var translated)) return translated;
        var result = value;
        foreach (var pair in Text.Where(p => p.Key.Length > 3).OrderByDescending(p => p.Key.Length))
            result = result.Replace(pair.Key, pair.Value, StringComparison.Ordinal);
        return result;
    }
}

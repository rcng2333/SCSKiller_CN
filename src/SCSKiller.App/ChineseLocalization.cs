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

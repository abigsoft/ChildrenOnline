<?php

namespace app\admin\middleware;
use app\admin\model\AdminAuthGroupAccessModel;
use app\admin\model\AdminAuthGroupModel;
use app\admin\model\AdminAuthRuleModel;
use app\admin\model\AdminModel;
use ReflectionClass;
use Webman\MiddlewareInterface;
use Webman\Http\Response;
use Webman\Http\Request;

class AuthMiddleware implements MiddlewareInterface
{
    public function process(Request $request, callable $handler) : Response
    {
        // 通过反射获取控制器哪些方法不需要登录
        $controller = new ReflectionClass($request->controller);

        $noNeedLogin = $controller->getDefaultProperties()['noNeedLogin'] ?? [];

        $admin = session('admin');
        $admin_id = session('admin_sign') == data_auth_sign($admin) ? session('admin_id') : 0;

        if( !$admin_id && !in_array(strtolower($request->getController()),['login','callback','upload','common'])){
            return redirect('/admin/login/index');
        }
        $admin_info = null;
        if(!in_array($request->action, $noNeedLogin)){
            $admin_info = AdminModel::where('id', $admin_id)->find();
            $url =  $request->path();

            if ($admin_info['is_admin'] != 1) {
                $auth_rule = [];
                $group_ids = AdminAuthGroupAccessModel::where('uid',$admin_id)
                    ->column('group_id');
                $rules_list = AdminAuthGroupModel::where('id','in',$group_ids)
                    ->where('status',1)
                    ->column('rules');
                foreach ($rules_list as $rules){
                    $auth_rule = array_merge($auth_rule,explode(',',$rules));
                }
                $auth_rule_url = AdminAuthRuleModel::where('name',$url)
                    ->where('status',1)
                    ->whereIn('id',$auth_rule)
                    ->isExists();
                if($auth_rule_url){
                    return redirect('/404.html');
                }
            }

        }
        $request->admin_info = $admin_info;
        $request->admin_id = $admin_id;
        // 不需要登录，请求继续向洋葱芯穿越
        return $handler($request);
    }
}
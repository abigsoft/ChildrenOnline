<?php

namespace app\admin\controller;


use app\admin\model\AdminAuthRuleModel;
use app\common\controller\BaseController;

class Index extends BaseController
{
    public function index()
    {
        $auth = new \liliuwei\think\Auth();
        $data = AdminAuthRuleModel::order('sort asc,id desc')
            ->where('is_show',1)
            ->where('status',1)
            ->select()->toArray();
        $data = list_to_tree($data);
        if ($this->admin_info['is_admin'] != 1) {
            foreach ($data as $k => $v) {
                if (!$auth->check($v['name'], session('admin_id'))) {
                    unset($data[$k]);
                } else {
                    if (isset($v['_child'])) {
                        foreach ($v['_child'] as $key => $value) {
                            if (!$auth->check($value['name'], session('admin_id'))) {
                                unset($data[$k]['_child'][$key]);
                            }
                        }
                    }
                }
            }
        }
        $this->assign('menus',$data);
        return view('index');
    }

    //后台首页框架内容
    public function main()
    {
        //会员总数
        $version = Db::query('SELECT VERSION() AS ver');
        $config = [
            'url' => $_SERVER['HTTP_HOST'],
            'document_root' => $_SERVER['DOCUMENT_ROOT'],
            'server_os' => PHP_OS,
            'server_port' => $_SERVER['SERVER_PORT'],
            'server_soft' => $_SERVER['SERVER_SOFTWARE'],
            'php_version' => PHP_VERSION,
            'mysql_version' => $version[0]['ver'],
            'max_upload_size' => ini_get('upload_max_filesize')
        ];
        $this->assign('config', $config);
        return view('main');
    }

    function password(){
        if(!$this->request->isAjax()){
            return view('password');
        }
        $password = $this->request->post('password');
        $old_pass = $this->request->post('old_pass');

        $old_pass = buildPass($old_pass);
        if($old_pass != (AdminModel::where('id',$this->admin_info->id)->value('password',''))){
            return $this->err('原密码输入不正确');
        }
        $password = buildPass($password);
        if($password == $old_pass){
            return $this->ajaxReturn($this->errorCode,'密码没有做修改');
        }
        AdminModel::where('id',$this->admin_info->id)->update(['password'=>$password]);
        return $this->suc('修改成功');
    }
}
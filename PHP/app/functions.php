<?php

use app\common\model\ConfigModel;
use app\common\model\DictModel;
use support\Cache;
use support\Db;

/**
 * Here is your custom functions.
 */

function formatDate($timestamp = false, $str = 'Y-m-d H:i:s')
{
    if (!$timestamp) {
        $timestamp = time();
    }
    return date($str, $timestamp);
}

/**
 * 随机字符
 * @param int $length 长度
 * @param string $type 类型
 * @param int $convert 转换大小写 1大写 0小写
 * @return string
 */
function random(int $length = 10, string $type = 'letter', int $convert = 0)
{
    $config = array(
        'number' => '1234567890',
        'letter' => 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ',
        'string' => 'abcdefghjkmnpqrstuvwxyzABCDEFGHJKMNPQRSTUVWXYZ23456789',
        'all' => 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890'
    );

    if (!isset($config[$type])) $type = 'letter';
    $string = $config[$type];

    $code = '';
    $strlen = strlen($string) - 1;
    for ($i = 0; $i < $length; $i++) {
        $code .= $string[mt_rand(0, $strlen)];
    }
    return ($convert == 1) ? strtoupper($code) : strtolower($code);
}

/**
 * tp官方数组查询方法废弃，数组转化为现有支持的查询方法
 * @param array $data 原始查询条件
 * @return array
 */
function formatWhere(array $data): array
{
    $where = [];
    foreach ($data as $k => $v) {
        if (($v == null || $v == '') || (is_int($k) && !is_array($v)) || (is_array($v) && count($v) < 2)) {
            continue;
        }
        if (count($v) == 2) {
            if($v[1] == null || $v[1] == ''){
                continue;
            }
            $where[] = [$v[0], '=', $v[1]];
        }else{
            $type = strtolower($v[1]);
            if ($v[2] == '' || $v[2] == null) {
                continue;
            }
            switch ($type) {
                case "like":
                    $where[] = [$v[0], 'like', '%' . str_replace(' ', '%', $v[2]) . '%'];
                    break;
                case 'exp':
                    $v[0] = Db::raw($v[2]);
                    break;
                case 'between':
                    if (is_string($v[2]) && stripos($v[2], ' - ') !== false) {
                        $v[2] = explode(' - ', $v[2]);
                    }
                    $where[] = [$v[0], 'between', $v[2]];
                    break;
                case 'between time':
                    if (is_string($v[2]) && stripos($v[2], '-') !== false) {
                        $v[2] = explode(' - ', $v[2]);
                    }
                    if (!$v[2][0] && !$v[2][1]) {
                        break;
                    }
                    if ($v[2][0] == null) {
                        $v[2][0] = date('Y-m-d H:i:s', 0);
                    }
                    if ($v[2][1] == null) {
                        $v[2][1] = date('Y-m-d H:i:s');
                    }
                    $where[] = [$v[0], 'between time', $v[2]];
                    break;
                case 'find in set':
                    if(is_array($v[2])){
                        $v[2] = implode(',',$v[2]);
                    }
                    $where[] = [$v[0], 'find in set', $v[2]];
                    break;
                default:
                    $where[] = [$v[0], $type, $v[2]];
                    break;
            }
        }
    }
    return $where;
}

function decimal($str, $format = 2): string
{
    if (!$str) {
        return "0.00";
    }
    return number_format($str, $format, ".", "");
}

function buildPass($password): string
{
    return md5($password . config('my.password_secret'));
}

function doOrderSn($type)
{
    $str = sprintf('%06d', Cache::inc('order_sn_' . date('Ymd') . '_' . $type));
    return date('Ymd') . $type . $str;
}

function upload_replace($str)
{
    $farr = ["/php|php3|php4|php5|phtml|pht|/is"];
    $str = preg_replace($farr, '', $str);
    return $str;
}

function buildConfig()
{
    $config_data = Cache::get('sys');
    if (!$config_data) {
        $list = ConfigModel::select()->column('data', 'name');
        Cache::set('sys', $list);
    }
}

function buildDict()
{
    $config_data = Cache::get('config_dict');
    if (!$config_data) {
        $array_dict = [];
        $list = DictModel::where('status',1)->column('name,type,data');
        //1 文本;2 整数;3 小数;4 真假;5 数组;6 枚举
        foreach ($list as $v){
            if($v['type'] == 2){
                $array_dict[$v['name']] = intval($v['data']);
            }elseif($v['type'] == 3){
                $array_dict[$v['name']] = floatval($v['data']);
            }elseif($v['type'] == 4){
                if(strtolower($v['data']) == 'true'){
                    $array_dict[$v['name']] = true;
                }elseif(strtolower($v['data']) == 'false'){
                    $array_dict[$v['name']] = false;
                }else{
                    $array_dict[$v['name']] = $v['data'];
                }
            }elseif($v['type'] == 5){
                if($v['data']){
                    $array_dict[$v['name']] = explode(',',$v['data']);
                }else{
                    $array_dict[$v['name']] = [];
                }
            }elseif($v['type'] == 6){
                if($v['data']){
                    $arr = explode(",",str_replace('：',':',$v['data']));
                    $type_value = [];
                    foreach($arr as $vv){
                        if(strpos($vv,':')){
                            list($a,$b) = explode(':',$vv);
                            $type_value[$a] = $b;
                        }else{
                            $type_value = $arr;
                        }
                    }
                    $array_dict[$v['name']] = $type_value;
                }else{
                    $array_dict[$v['name']] = [];
                }
            }else{
                $array_dict[$v['name']] = $v['data'];
            }
        }
        Cache::set('dict', $array_dict);
    }
}

//导出excel表头设置
function getTag($key3, $no = 100)
{
    $data = [];
    $key = ord("A");//A--65
    $key2 = ord("@");//@--64
    for ($n = 1; $n <= $no; $n++) {
        if ($key > ord("Z")) {
            $key2 += 1;
            $key = ord("A");
            $data[$n] = chr($key2) . chr($key);//超过26个字母时才会启用
        } else {
            if ($key2 >= ord("A")) {
                $data[$n] = chr($key2) . chr($key);//超过26个字母时才会启用
            } else {
                $data[$n] = chr($key);
            }
        }
        $key += 1;
    }
    return $data[$key3];
}

/**
 * 获取带域名的图片地址
 * @param     $image
 * @return
 */
function getImgFullPath($image, $domain)
{
    return ((strpos(strtolower($image), 'http://') || strpos(strtolower($image), 'https://')) ? "" : $domain) . $image;
}

function data_auth_sign($data)
{
    //数据类型检测
    if (!is_array($data)) {
        $data = (array)$data;
    }
    ksort($data); //排序
    $code = http_build_query($data); //url编码并生成query字符串
    $sign = sha1($code); //生成签名
    return $sign;
}

/**

 * 下划线转驼峰
 * 思路:
 * step1.原字符串转小写,原字符串中的分隔符用空格替换,在字符串开头加上分隔符
 * step2.将字符串中每个单词的首字母转换为大写,再去空格,去字符串首部附加的分隔符.
 */
function camelize($uncamelized_words,$separator='_')
{
    $uncamelized_words = $separator. str_replace($separator, " ", strtolower($uncamelized_words));
    return ltrim(str_replace(" ", "", ucwords($uncamelized_words)), $separator );
}

/**
 * 驼峰命名转下划线命名
 * 思路:
 * 小写和大写紧挨一起的地方,加上分隔符,然后全部转小写
 */
function uncamelize($camelCaps,$separator='_')
{
    return strtolower(preg_replace('/([a-z])([A-Z])/', "$1" . $separator . "$2", $camelCaps));
}
//驼峰命名转下划线命名
function toUnderScore($str)
{
    $dstr = preg_replace_callback('/([A-Z]+)/',function($matchs)
    {
        return '_'.strtolower($matchs[0]);
    },$str);
    return trim(preg_replace('/_{2,}/','_',$dstr),'_');
}

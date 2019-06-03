<?php
include 'config.php';
function work($lnkname)
{
	$testvar = '';
	$result;
	$host = dataclass::$data_base_adress;
	$dbname = dataclass::$data_base_name;
	$dbuser = dataclass::$data_base_user;
	$dbpswd = dataclass::$data_base_password;
	$conn = new mysqli($host, $dbuser, $dbpswd, $dbname);
	if ($conn->connect_error)
	{
		echo 'Error 404';
	}
	// Удалить 'clo' так как это для локалхоста
	// Создаем дирректорию кэша
	if(is_dir($_SERVER['DOCUMENT_ROOT'].'/setfiles/cache') || is_dir($_SERVER['DOCUMENT_ROOT'].'/public_html/setfiles/cache'))
	{}
	else
	{
		mkdir($_SERVER['DOCUMENT_ROOT'].'/setfiles/cache');
	}
	$user_ip = $_SERVER['REMOTE_ADDR'];
	//$user_ip = '255.255.255.100'; // Для тестирования на localhost
	
	// Отсеиваем V6 айпишники	
	if(filter_var($user_ip, FILTER_VALIDATE_IP, FILTER_FLAG_IPV6))
	{
		$vsix_request = "SELECT botpages FROM rules WHERE linknames = '".$lnkname."'";
		$vsix_adress = mysqli_fetch_row(mysqli_query($conn, $vsix_request));
		header('Location: '.$vsix_adress[0]);
		die();
	}
	// Чекаем айпи адрес по базе
	$ip_check = "SELECT id FROM ip_table WHERE (INET_ATON(ip_start) <= INET_ATON('".$user_ip."')) AND (INET_ATON(ip_end) >= INET_ATON('".$user_ip."'))";
	$result = mysqli_num_rows(mysqli_query($conn, $ip_check));
	$stat_location_send;
	// Направляем пользователя туда куда надо
	if ($result > 0)
	{
		$bot_file;
		$bot_cache_path;
		$bot_adress_from_cache;
		if(file_exists($_SERVER['DOCUMENT_ROOT'].'/setfiles/cache/'.$lnkname.'_black.txt') || file_exists($_SERVER['DOCUMENT_ROOT'].'/public_html/setfiles/cache/'.$lnkname.'_black.txt'))
		{
			if(strpos($_SERVER['DOCUMENT_ROOT'], 'public_html') == true)
			{
				$bot_cache_path = $_SERVER['DOCUMENT_ROOT'].'/setfiles/cache/'.$lnkname.'_black.txt';
			}
			else
			{
				$bot_cache_path = $_SERVER['DOCUMENT_ROOT'].'/public_html/setfiles/cache/'.$lnkname.'_black.txt';
			}
			$bot_adress_from_cache = file_get_contents($bot_cache_path);
			header('Location: '.$bot_adress_from_cache);
		}
		else
		{
			$bot_pg_request = "SELECT botpages FROM rules WHERE linknames = '".$lnkname."'";
			$botpage_adress = mysqli_fetch_row(mysqli_query($conn, $bot_pg_request));
			header('Location: '.$botpage_adress[0]);
			if(strpos($_SERVER['DOCUMENT_ROOT'], 'public_html') == true)
			{
				$bot_cache_path = $_SERVER['DOCUMENT_ROOT'].'/setfiles/cache/'.$lnkname.'_black.txt';
			}
			else
			{
				$bot_cache_path = $_SERVER['DOCUMENT_ROOT'].'/public_html/setfiles/cache/'.$lnkname.'_black.txt';
			}
			$bot_file = fopen($bot_cache_path, 'w');
			fwrite($bot_file, $botpage_adress[0]);
			fclose($bot_file);			
		}
		$stat_location_send = 'bot';
	}
	else
	{
		$white_file;
		$white_cache_path;
		$white_adress_from_cache;
		if(file_exists($_SERVER['DOCUMENT_ROOT'].'/setfiles/cache/'.$lnkname.'_white.txt') || file_exists($_SERVER['DOCUMENT_ROOT'].'/public_html/setfiles/cache/'.$lnkname.'_white.txt'))
		{
			if(strpos($_SERVER['DOCUMENT_ROOT'], 'public_html') == true)
			{
				$white_cache_path = $_SERVER['DOCUMENT_ROOT'].'/setfiles/cache/'.$lnkname.'_white.txt';
			}
			else
			{
				$white_cache_path = $_SERVER['DOCUMENT_ROOT'].'/public_html/setfiles/cache/'.$lnkname.'_white.txt';
			}
			$white_adress_from_cache = file_get_contents($white_cache_path);
			header('Location: '.$white_adress_from_cache);			
		}
		else
		{
			$goal_pg_request = "SELECT selpages FROM rules WHERE linknames = '".$lnkname."'";
			$goal_pg_adress = mysqli_fetch_row(mysqli_query($conn, $goal_pg_request));
			header('Location: '.$goal_pg_adress[0]);
			if(strpos($_SERVER['DOCUMENT_ROOT'], 'public_html') == true)
			{
				$white_cache_path = $_SERVER['DOCUMENT_ROOT'].'/setfiles/cache/'.$lnkname.'_white.txt';
			}
			else
			{
				$white_cache_path = $_SERVER['DOCUMENT_ROOT'].'/public_html/setfiles/cache/'.$lnkname.'_white.txt';
			}
			$white_file = fopen($white_cache_path, 'w');
			fwrite($white_file, $goal_pg_adress[0]);
			fclose($white_file);			
		}
		$stat_location_send = 'wht';
	}
	
	// Собираем данные
	// Данных для таблицы можно больше добавлять
	// В последующем вынести в скрипт MaxMind
	//$create_query = "CREATE TABLE IF NOT EXISTS ip_stat (id INT AUTO_INCREMENT PRIMARY KEY, data_time DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP, ip_adress VARCHAR(16) NOT NULL, send_loc VARCHAR(3) NOT NULL, country VARCHAR(10) NOT NULL, link_name VARCHAR(150) NOT NULL) ENGINE=INNODB";
	//mysqli_query($conn, $create_query); // Создаем таблицу статистики если она не существует
	// Добавляем значения в таблицу
	//$stat_insert_query = "INSERT INTO ip_stat (send_loc, ip_adress, link_name) VALUES ('".$stat_location_send."', '".$user_ip."', '".$lnkname."')";
	//mysqli_query($conn, $stat_insert_query);
	mysqli_close($conn);
}
?>
def palindromic
	highest_palindromic = 0
		for i in 1..999
			for j in 1..999
				
				total_number = i*j
				string_total_number = total_number.to_s
				reversed_string = string_total_number.reverse	
						
						if (string_total_number== reversed_string && highest_palindromic < total_number)
							highest_palindromic = total_number
						end
			end 
		end
	return highest_palindromic	 
end

puts palindromic
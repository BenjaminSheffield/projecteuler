def modulus_checker
totalNumber = 600851475143

		(2..totalNumber).map do |x| 

				if totalNumber % x == 0 && x != totalNumber
						totalNumber = totalNumber / x	
				end
				
				if totalNumber == x
						return totalNumber
				end	
		end
end

puts modulus_checker

class Jedi < ActiveRecord::Base
  has_many :lightsabers, as: :warrior

  def energy_color
    ['green', 'blue', 'purple'].sample
  end
end

class Sith < ActiveRecord::Base
  has_many :lightsabers, as: :warrior

  def energy_color
    'red'
  end
end

class Lightsaber < ActiveRecord::Base
  belongs_to :warrior, polymorphic: :true, after_add: :set_color

  def set_color(warrior)
    self.color = warrior.energy_color
  end
end

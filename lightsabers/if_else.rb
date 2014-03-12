class Jedi < ActiveRecord::Base
  has_many :lightsabers, as: :wieldable
end

class Sith < ActiveRecord::Base
  has_many :lightsabers, as: :wieldable
end

class Lightsaber < ActiveRecord::Base
  belongs_to :wieldable, polymorphic: true, after_add: :set_color

  def set_color(warrior)
    if warrior.class == Jedi
      self.color = ['green', 'blue', 'purple'].sample
    else
      self.color = 'red'
    end
  end
end
